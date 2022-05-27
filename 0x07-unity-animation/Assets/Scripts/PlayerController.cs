using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float gravity = 9f;
    [SerializeField]
    private float jumpSpeed = 5f;

    [SerializeField]
    Transform cameraTransform;

    public Animator animator;

    private CharacterController controller;

    private float directionY;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);

        if (controller.isGrounded)
        {
            animator.SetBool("isJumping", false);
            animator.SetBool("isGrounded", true);
            animator.SetBool("isFalling", false);
        }
        else
            animator.SetBool("isGrounded", false);
        
        // rotate with the camera
        direction = Quaternion.AngleAxis(cameraTransform.rotation.eulerAngles.y, Vector3.up) * direction;
        
        //Runnig
        if (direction.magnitude > 0.05f)
        {
            gameObject.transform.forward = direction;
            animator.SetBool("isRunning", true);
        }
        else
            animator.SetBool("isRunning", false);
        
        //Jump
        if (controller.isGrounded && Input.GetButtonDown("Jump"))
        {
            directionY = jumpSpeed;
            animator.SetBool("isJumping", true);
        }

        directionY -= gravity * Time.deltaTime;

        direction.y = directionY;

        controller.Move(direction * speed * Time.deltaTime);

        if (transform.position.y < -50)
        {
            transform.position = new Vector3(0f, 40f, 0f);
        }

        if (transform.position.y < -5)
        {
            animator.SetBool("isFalling", true);
        }
    }
}
