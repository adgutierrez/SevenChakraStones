using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
   float xAngle = 0.0f;
   //float yAngle = 1.0f;
   float zAngle = 0.0f;
    [SerializeField] float xAngleRotateSpeed = 0;
   // [SerializeField] float yAngleRotateSpeed = 0;
    [SerializeField] float zAngleRotateSpeed = 0;

    [SerializeField] float rotateSpeed = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // todo: serialize bool to tuen on/off and set spin speed
        xAngle = xAngle + xAngleRotateSpeed;
       // xAngle = xAngle + yAngleRotateSpeed;
        xAngle = xAngle + zAngleRotateSpeed;


        Quaternion gameObject = Quaternion.Euler(0, xAngle, zAngle);

        transform.rotation = Quaternion.Slerp(transform.rotation,
                                        gameObject, Time.deltaTime * rotateSpeed);
    }
}
