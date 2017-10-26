using UnityEngine;
using System.Collections;

public class Player2Movement : MonoBehaviour
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
        float moveHorizontal = Input.GetAxisRaw("Horizontal1");
        float moveVertical = Input.GetAxisRaw("Vertical1");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15F);


        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);

    }

}