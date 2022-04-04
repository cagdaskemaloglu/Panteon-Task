using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isFall = false;
    public bool onPaint;
    private Animator anim;
    private PlayerMovement playerMovement;

    //---Rank---
    [SerializeField] private Transform[] opponentPlayers;
    public int _rank;
    //---EndRank---


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(FallingAnim());
        Rank();

        if(transform.position.y < -.5f)
        {
            isFall = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "FinishLine")
        {
            onPaint = true;
            playerMovement.speed = 0;
            anim.SetBool("isStop", true);
            transform.rotation = Quaternion.Slerp(Quaternion.identity,Quaternion.Euler(0,180,0), Time.deltaTime * 45);
        }
    }

    void Rank()
    {
        if (!onPaint)
        {
            int numberOfFrontPlayers = 0;

            for (int i = 0; i < opponentPlayers.Length; i++)
            {
                Vector3 relativePosition = transform.InverseTransformPoint(opponentPlayers[i].transform.position);
                if (relativePosition.z < 0)
                {
                    numberOfFrontPlayers++;
                }
                _rank = (opponentPlayers.Length + 1 - numberOfFrontPlayers);
                Debug.Log("Current Rank ::  " + (opponentPlayers.Length + 1 - numberOfFrontPlayers));
            }
        }
   
    }

    IEnumerator FallingAnim()
    {
        if (isFall)
        {
            anim.SetBool("isFalling", true);
            yield return new WaitForSeconds(1f);
            anim.SetBool("isFalling", false);
            isFall = false;
            transform.position = new Vector3(0, .5f, -2.5f);

        }
    }
}
