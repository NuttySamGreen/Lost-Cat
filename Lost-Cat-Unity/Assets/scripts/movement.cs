using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody prb;
    public Camera mcamera;
    public float speed;
    public float X_Offset;
    public float Y_Offset;
    public float Z_Offset;
    
    // Start is called before the first frame update
    void Start()
    {
        mcamera = Camera.main;
        
    }

    // Update is called once per frame
    void Update()
    {
       
       if (Input.GetKey("w"))
        {
            prb.velocity = new Vector3(mcamera.transform.forward.x*speed,prb.velocity.y, mcamera.transform.forward.z * speed);
            prb.transform.rotation = new Quaternion(0, -mcamera.transform.rotation.y, 0, 1);
        }
        if (Input.GetKey("s"))
        {
            prb.velocity = new Vector3(mcamera.transform.forward.x * -speed, prb.velocity.y, mcamera.transform.forward.z * -speed);
            prb.rotation = new Quaternion(0, (mcamera.transform.rotation.y + 180), 0, 0);
        }
        if (Input.GetKey("a"))
        {
            prb.velocity = new Vector3(mcamera.transform.right.x * -speed, prb.velocity.y, mcamera.transform.right.z * -speed);
            prb.rotation = new Quaternion(0, mcamera.transform.rotation.y, 0, 1);
        }
        if (Input.GetKey("d"))
        {
            prb.velocity = new Vector3(mcamera.transform.right.x * speed, prb.velocity.y, mcamera.transform.right.z * speed);
            prb.rotation = new Quaternion(0, mcamera.transform.rotation.y, 0, 1);
        }










    }
}
