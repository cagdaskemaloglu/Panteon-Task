using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private Vector3 offset = new Vector3(0, .8f, -1f);
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        

        if (player.GetComponent<Player>().onPaint)
        {
            Vector3 moveVector = player.transform.position + new Vector3(0,0.4f,-.7f);
            transform.position = moveVector;
            Camera.main.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            Vector3 moveVector = player.transform.position + offset;
            transform.position = moveVector;
            Camera.main.transform.rotation = Quaternion.Euler(25, 0, 0);
        }

    }
}
