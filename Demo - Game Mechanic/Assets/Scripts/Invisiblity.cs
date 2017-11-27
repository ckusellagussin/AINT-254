using UnityEngine;
using System.Collections;

public class Invisiblity : MonoBehaviour {


    GameObject invis;


    // Use this for initialization
    void Start()
    {


      
    }
   public void Awake()
    {   
        SetVisibility(gameObject, false);     
    }




    void SetVisibility(GameObject obj, bool visible)
   {
        foreach (Renderer rend in obj.GetComponentsInChildren<Renderer>())
        {
           rend.enabled = visible;
        }
    }



    // Update is called once per frame
    void Update () {
	



	}
}
