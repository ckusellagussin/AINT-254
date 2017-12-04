using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public float movementSpeed = 2.00f;

    // Use this for initialization
    void Start()
    {
        
    }

    void Update()
    {
        ControllPlayer();

    }


    void ControllPlayer()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15F);
            
        }

        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);

    }

}