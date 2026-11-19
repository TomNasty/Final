using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;
    public float speedMultiplier; //will affect speed calc
    public float groundDrag;
    public float jumpForce;
    public float jumpCooldown;
    public float airMult;
    bool readyToJump;
    [Header("Keybinds")]
    public KeyCode jumpKey = KeyCode.Space;
    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;
    public Transform orientation;
    float horizInput;
    float vertInput;
    Vector3 moveDir;
    Rigidbody rb;
    public float booletDuration;
    public Rigidbody boolet;
    public float booletSpeed;
    public GameObject cameraRotation;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        readyToJump = true;
    }
    private void Update()
    {
        //ground check
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);
        MyInput();
        SpeedControl();
        //handle drag
        /*if (grounded)
            rb.drag = groundDrag;
        else
            rb.drag = 0f;
        if (Input.GetMouseButtonDown(0))
        {
            SpawnBoolet();
        }*/
    }
    private void SpawnBoolet()
    {
        Rigidbody projectile = Instantiate(boolet, transform.position, cameraRotation.transform.rotation);
        projectile.maxLinearVelocity = booletSpeed;
    }
    private void FixedUpdate()
    {
        MovePlayer();
    }
    private void MyInput()
    {
        horizInput = Input.GetAxisRaw("Horizontal");
        vertInput = Input.GetAxisRaw("Vertical");
        //when to jump
        if (Input.GetKey(jumpKey) && readyToJump && grounded)
        {
            readyToJump = false;
            Jump();
            Invoke(nameof(ResetJump), jumpCooldown);
        }
    }
    private void MovePlayer()
    {
        //calculate movement direction
        moveDir = orientation.forward * vertInput + orientation.right * horizInput;
        //on ground
        if (grounded)
            rb.AddForce(moveDir.normalized * moveSpeed * speedMultiplier, ForceMode.Force);
        else if (!grounded)
            rb.AddForce(moveDir.normalized * moveSpeed * speedMultiplier * airMult, ForceMode.Force);
    }
    private void SpeedControl()
    {
        /*Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        //limit if need
        if (flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }*/
    }
    private void Jump()
    {
        //reset y vel
        /*rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);*/

    }
    private void ResetJump()
    {
        readyToJump = true;
    }
}