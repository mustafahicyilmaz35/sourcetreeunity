using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHareket : MonoBehaviour
{
    Animator animator;
    public float hiz = 10f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

   
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isRunning", true);
            transform.position += transform.forward*Time.deltaTime*hiz;
           
        }
        else
        {
            animator.SetBool("isRunning", false);
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -90*hiz*Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 90 * hiz * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(0, 180 * 3 * Time.deltaTime, 0));
        }



    }
}
