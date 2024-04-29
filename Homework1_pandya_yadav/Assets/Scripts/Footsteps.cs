using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource footstepsound;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.RightArrow)) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S))
        {
            footstepsound.enabled = true;
            
        }  
        else
        {
            footstepsound.enabled = false;
        }
    }
}
