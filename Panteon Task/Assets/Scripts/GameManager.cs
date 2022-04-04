using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int taskNumber = 0;

    //---Task2---
    private Player player;
    private Transform playerTransform;
    public GameObject paintable;
    private bool doOnce = true;
    //---EndTask2---

    //---Task3---
    public Text rankText;

    //---EndTask3---

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (taskNumber == 1)
        {
            if (player.onPaint)
            {
                Debug.Log("Parkour Completed!");
            }
        }
        if (taskNumber == 2)
        {
            if (player.onPaint && doOnce)
            {
                GameObject paint = Instantiate(paintable, new Vector3(playerTransform.position.x, .8f, 24.5f), Quaternion.Euler(270f, 0, 0));
                doOnce = false;
            }
        }
        if (taskNumber == 3)
        {
            rankText.text = "Rank:"+ player._rank.ToString();
    
        }

    }
}
