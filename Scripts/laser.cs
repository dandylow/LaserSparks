using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class laser : MonoBehaviour
{

    private LineRenderer lr;
    public GameObject dot;
    public bool active = true;
   

    public int amp;
    void Start()
    {
       
        lr = GetComponent<LineRenderer>();
        
    }
   

    // Update is called once per frame
    void FixedUpdate()
    {
       
        
        dot.transform.position = new Vector3(0, 0, 0);
        /*if (Input.touchCount > 1)
        {
             //Vibration.Vibrate(milliseconds: 1, amplitude: 20);
        */

            lr.enabled = true;
            lr.SetPosition(0, transform.position);
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {

                if (hit.collider)
                {
                    lr.SetPosition(1, hit.point);
                    dot.transform.position = hit.point;

                }
                else
                {
                    dot.transform.position = new Vector3(0, 0, 0);
                }
            }
            else lr.SetPosition(1, transform.position + transform.forward * 5000);/*
        }
        else
        {
           
            lr.enabled = false;
        }*/
    }
}