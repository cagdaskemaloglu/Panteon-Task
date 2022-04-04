using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Task1()
    {
        //SceneManager.LoadScene("Task1", LoadSceneMode.Additive);
        SceneManager.LoadScene(1);
    }

    public void Task2()
    {
        SceneManager.LoadScene(2);
    }

    public void Task3()
    {
        SceneManager.LoadScene(3);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
