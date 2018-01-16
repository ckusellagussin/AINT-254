using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raycasting : MonoBehaviour {

    public float maxRayDistance = 3;
    public Text TextReveal;

    private int enemyRevealCount = 0;
    

    // Use this for initialization
    void Start()
    {

        enemyRevealCount = 0;
        SetRevealText();
    }




    private void FixedUpdate()
    {
        Ray ray = new Ray(transform.position, -transform.up);
        RaycastHit hit;


        Debug.DrawRay(ray.origin, ray.direction * maxRayDistance, Color.red);


        if (Physics.Raycast(ray, out hit, maxRayDistance))
        {

            SetRevealText();
            enemyRevealCount += 1;


            if (hit.transform.gameObject.tag == "Enemy")
            {

                Debug.Log("You hit a ray");
                rayHitInvis(hit.transform);

                SetRevealText();
                enemyRevealCount += 1;


            }


        }


    }

    void SetRevealText ()
        
    {

        TextReveal.text = "Enemies Revealed: " + enemyRevealCount.ToString();
    }


    private void rayHitInvis(Transform hit)
    {
        hit.GetComponent<Invisiblity>().SetVisibility(hit.transform.gameObject, true);
        


    }
   

}
