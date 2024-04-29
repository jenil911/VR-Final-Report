using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    Rigidbody dragonRigidBodyObject;

    public static float verticalInput;
    public static float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        dragonRigidBodyObject = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        dragonRigidBodyObject.velocity = new Vector3(horizontalInput*50, dragonRigidBodyObject.velocity.y, verticalInput*50);
    }
}
