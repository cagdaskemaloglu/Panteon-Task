using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaintWall : MonoBehaviour
{
    public GameObject brush;
    private float brushSize = 2f;

    public Slider percentage;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

         if (Input.GetMouseButton(0))
         {
             var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             RaycastHit hit;
             if(Physics.Raycast(Ray,out hit))
             {
                 if (hit.transform.gameObject.tag == "Paintable")
                 {
                     var go = Instantiate(brush, hit.point + -Vector3.forward * 0.1f, Quaternion.Euler(180, 0, 0), transform);
                     go.transform.localScale = Vector3.one * brushSize;
                 }
             }

         }


    }


   

}
