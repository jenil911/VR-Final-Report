using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    PhotonView view;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine) 
        {
            if (Input.GetKeyDown("space"))
            {
                rb.velocity= new Vector3(0,5,0);
            }
            if (Input.GetKeyDown("up"))
            {
                rb.velocity= new Vector3(0,0,5);
            }
            if (Input.GetKeyDown("down"))
            {
                rb.velocity= new Vector3(0,0,-5);
            }
            if (Input.GetKeyDown("right"))
            {
                rb.velocity= new Vector3(5,0,0);
            }
            if (Input.GetKeyDown("left"))
            {
                rb.velocity= new Vector3(-5,0,0);
            }
        }
    }
}
