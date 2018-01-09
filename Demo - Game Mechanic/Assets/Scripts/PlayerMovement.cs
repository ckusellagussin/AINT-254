using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 3.00f;

    private new Rigidbody rigidbody;
    private Vector3 moveInput;
    private Vector3 moveVelocity;



    // Use this for initialization
    void Start()
    {

        rigidbody = GetComponent<Rigidbody>();

    }

    void Update()
    {
        ControllPlayer();

    }


    void ControllPlayer()
    {
        moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        moveVelocity = moveSpeed * moveInput;

         Vector3 playerDirection = Vector3.right * Input.GetAxisRaw("HorizontalR") + Vector3.forward * -Input.GetAxisRaw("VerticalR");

         if (playerDirection.sqrMagnitude > 0.0f)

        {
            transform.rotation = Quaternion.LookRotation(playerDirection, Vector3.up);

         }

    }

    void FixedUpdate()
    {

        rigidbody.velocity = moveVelocity;

    }


}