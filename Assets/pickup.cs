using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pickup : MonoBehaviour
{
    public Rigidbody rb;

    public Transform guide;

    bool grabcheck = false;

    public float speed = 2;

    public float rbspeed = 15;

    public AudioSource onpickup;

    bool firstpickup = false;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    

    // Update is called once per frame
    void Update()
    {
        if (grabcheck == true)
        {
            transform.position = Vector3.Lerp(transform.position, guide.transform.position, Time.deltaTime * speed);
            rb.velocity = Vector3.zero;
        } 
    }

    private void OnMouseDown()
    {
        if (firstpickup == false)
        {
            onpickup.Play();
        }
        grabcheck = true;
        rb.useGravity = false;
        firstpickup = true;
    }

    private void OnMouseUp()
    {
        grabcheck = false;
        rb.useGravity = true;
        //rb.velocity = guide.transform.position - transform.position * rbspeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        speed = 2;
    }

    private void OnCollisionExit(Collision collision)
    {
        speed = 15;
    }
}

//Met dank aan Simon de Bruine

