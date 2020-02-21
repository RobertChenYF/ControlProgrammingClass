using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    private Rigidbody rigidbodyThis;
    public float forwardBackward;
    public float rightLeft;
    public GameObject cameraFollow;
    public float velocity;


    // Start is called before the first frame update
    void Start()
    {
        rigidbodyThis = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        forwardBackward = Input.GetAxis("Vertical");

        rightLeft = Input.GetAxis("Horizontal");

    }

    void FixedUpdate()
    {
        
        rigidbodyThis.AddForce((cameraFollow.transform.forward)*forwardBackward*velocity,ForceMode.Impulse);

        //rigidbodyThis.AddForce((cameraFollow.transform.right) * rightLeft *velocity, ForceMode.Impulse);

        rigidbodyThis.AddTorque(new Vector3(0,velocity*rightLeft*Time.deltaTime,0),ForceMode.Impulse);
    }
}
