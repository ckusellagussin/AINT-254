using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour {

    public float maxRayDistance = 3;
    

    // Use this for initialization
    void Start()
    {
      


    }




    private void FixedUpdate()
    {
        Ray ray = new Ray(transform.position, -transform.up);
        RaycastHit hit;


        Debug.DrawRay(ray.origin, ray.direction * maxRayDistance, Color.red);


        if (Physics.Raycast(ray, out hit, maxRayDistance))
        {
          

            if (hit.transform.gameObject.tag == "Enemy")
            {

                Debug.Log("You hit a ray");
                rayHitInvis(hit.transform);


            }


        }

    }


    private void rayHitInvis(Transform hit)
    {
        hit.transform.gameObject.GetComponent<Invisiblity>().SetVisibility(hit.transform.gameObject, true);
        


    }
   

}
