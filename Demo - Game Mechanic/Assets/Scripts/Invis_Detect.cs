using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invis_Detect : MonoBehaviour
{

    Invisiblity invis;


    // Use this for initialization
    void Start()
    {

        invis = gameObject.AddComponent<Invisiblity>();

    }



    void OnTriggerEnter(Collider other)

    {

        isEnemy(other);

    }


    public void isEnemy(Collider other)
    {


        {

            if (other.gameObject.tag == "Enemy")
            {
                Debug.Log("Detected, It was a hit");

                other.gameObject.GetComponent<Invisiblity>().SetVisibility(other.gameObject, true);

            }
            else if (other.gameObject.tag != "Enemy")
            {

                Debug.Log("This is not an enemy but it still hit");

            }

        }

    }




     //Update is called once per frame
    void Update()
    {

        Vector3 ray1 = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, ray1, 10))
        {

            Debug.Log("Something has been seen");

        }




    }

}

