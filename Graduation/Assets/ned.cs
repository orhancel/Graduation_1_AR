using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ned : MonoBehaviour {
    public GameObject destination;
    // Use this for initialization
    void Start () {
        destination = this.gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        /*Debug.DrawRay(transform.position, destination.transform.position, Color.black);
        if (Input.GetKey(KeyCode.C))
        {
            destination = GameObject.Find("Needle_Target");
        }*/
    }
}
