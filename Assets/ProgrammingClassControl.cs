using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgrammingClassControl : MonoBehaviour
{
    private float xMove;
    private float yMove;
    private bool jump;
    public float speed;
    public float gravity;
    public float jumpSpeed;
    private Vector3 moveDirection;
    CharacterController characterController;
    public GameObject cameraOfThis;

    
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        xMove = Input.GetAxis("Horizontal");
        yMove = Input.GetAxis("Vertical");
        jump = Input.GetButton("Jump");

    }

    void FixedUpdate()
    {
        moveDirection = new Vector3(xMove, 0, yMove);
        moveDirection = moveDirection* speed;
        
        
        //if (characterController.isGrounded && jump)
        //{
       //     moveDirection.y = jumpSpeed;
       // }
        //moveDirection.y -= gravity * Time.fixedDeltaTime;
        //characterController.
        characterController.Move(moveDirection*Time.fixedDeltaTime);
    }
}
