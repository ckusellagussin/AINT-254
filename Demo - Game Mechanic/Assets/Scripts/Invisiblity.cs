using UnityEngine;
using System.Collections;

public class Invisiblity : MonoBehaviour {

	// Use this for initialization
	void Start () {

        gameObject.GetComponent<MeshRenderer>().enabled = false;

	}
	
    void OnCollisionEnter(Collision colission)
    {
        gameObject.GetComponent<MeshRenderer>().enabled = true;


    }

	// Update is called once per frame
	void Update () {
	
	}
}
