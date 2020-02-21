using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    public Rigidbody rigidbodyThis;
    public GameObject cameraThis;
    public GameObject cameraFollow;
    public float forwardBackward;
    public float velocity;
    public float rightLeft;
    public Vector3 InputVector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
       // forwardBackward = Input.GetAxis("Vertical");
      //  rightLeft = Input.GetAxis("Horizontal");
        
       // InputVector = rightLeft * cameraThis.transform.right + cameraThis.transform.forward * forwardBackward;
        float mouseY = Input.GetAxis("Mouse Y");
        print(mouseX + mouseY);

       // rigidbodyThis.AddTorque(new Vector3(0, mouseX * Time.deltaTime, 0), ForceMode.Impulse);
        //rigidbodyThis.AddForce((cameraFollow.transform.forward) * forwardBackward * 0.1f, ForceMode.Impulse);
       // rigidbodyThis.velocity = new Vector3(InputVector.x * velocity, rigidbodyThis.velocity.y ,InputVector.z*velocity);
       // rigidbodyThis.velocity -= new Vector3(0,9.8f*Time.deltaTime,0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbodyThis.AddForce(new Vector3(0,30,0), ForceMode.Impulse);
        }
       // cameraThis.transform.Rotate(new Vector3(0,mouseY,0));
        //transform.rotation = new Vector3(transform.rotation.x, Mathf.Clamp(-35.0f, 35.0f, transform.rotation.y + mouseY * Time.deltaTime));


    }
}
