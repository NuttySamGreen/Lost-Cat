using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraro : MonoBehaviour
{
    public float Mouse_Sensitivity = 5f;
    Camera crb;
    // Start is called before the first frame update
    void Start()
    {
        crb = this.GetComponent<Camera>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        if (Input.GetAxis("Mouse X") < 0)
        {
            crb.transform.Rotate(0,-Mouse_Sensitivity,0);
        }
        if (Input.GetAxis("Mouse X") > 0)
        {
            crb.transform.Rotate(0, Mouse_Sensitivity, 0);
        }
    }
}
