using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDController : MonoBehaviour
{
    public float force = 20f;
    public KeyCode UpButton;
    public KeyCode DownButton;
    public KeyCode LeftButton;
    public KeyCode RightButton;
    Rigidbody rb;

    //establishing the variables

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //this is the rigidbody of the object
    }

    // Update is called once per frame
    void Update()
    {
        bool hasInput = false;
        
        if(Input.GetKeyDown(UpButton)){
            hasInput = true;
            rb.velocity = new Vector3(0, 0, force); //moving this into z axis

        }

        if(Input.GetKeyDown(DownButton)){
            hasInput = true;
            rb.velocity = new Vector3 (0, 0, -force); //moving the other way

        }

        if(Input.GetKeyDown(LeftButton)){
            hasInput = true;
            rb.velocity = new Vector3 (-force, 0, 0); //moving it left

        }

        if(Input.GetKeyDown(RightButton)){
            hasInput = true;
            rb.velocity = new Vector3 (force, 0, 0); //moving it right

        }
//if not pressing anykey
        if(!Input.anyKey){
            rb.velocity = rb.velocity * 0.9f; // decrease the velocity

        }
    }
}
