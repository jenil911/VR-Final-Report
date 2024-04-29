using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    private bool JumpKeyWasPressed;
    private float HorizontalInput;
    private int SuperJumpRemaining;

    [SerializeField] private Transform GroundCheckTransform = null;
    [SerializeField] private LayerMask PlayerMask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpKeyWasPressed = true;
            //GetComponent<Rigidbody>().AddForce(Vector3.up*5, ForceMode.VelocityChange);
        }
        HorizontalInput = Input.GetAxis("Horizontal");
    }
    // Fixed 
    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(HorizontalInput*2.3f, GetComponent<Rigidbody>().velocity.y,0);
        if (Physics.OverlapSphere(GroundCheckTransform.position, 0.1f, PlayerMask).Length==0)
        {
            return;
        }
        
        if (JumpKeyWasPressed)
        {
            float JumpPower=7.0f;
            if(SuperJumpRemaining>0)
            {
                JumpPower=JumpPower*1.5f;
                SuperJumpRemaining--;
            }
            GetComponent<Rigidbody>().AddForce(Vector3.up*JumpPower, ForceMode.VelocityChange);
            JumpKeyWasPressed = false;
            
            
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer==7)
        {
            Destroy(other.gameObject);
            ScoreManager.instance.AddPoint();
            SuperJumpRemaining++;
            
        }
    }
}
