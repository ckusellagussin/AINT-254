using UnityEngine;
using System.Collections;

public class Invisiblity : MonoBehaviour {



    // Use this for initialization
    void Start()
    {


      
    }
    public void Awake()
    {
        gameObject.GetComponent<Renderer>().enabled = false;

     //   foreach (Transform child in transform)
      //  {

       //     child.GetComponent<Renderer>().enabled = false;
       // }

    }

    // Update is called once per frame
    void Update () {
	



	}
}
