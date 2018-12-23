using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line_to_Neck : MonoBehaviour {
    LineRenderer line;
    public GameObject neck;
    //public GameObject textHolder;
    public bool tip_ready = false;
    public bool neck_ready = false;
    private bool set = false;

	// Use this for initialization
	void Start () {
        line = GetComponent<LineRenderer>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (tip_ready && neck_ready && !set)
        {
            neck = GameObject.Find("Neck");
            line.SetPosition(0, transform.position);
            line.SetPosition(1, neck.transform.position);
            set = true;
        }
        if (set)
        {
            //textHolder.GetComponent<TextMesh>().text = (Vector3.Distance(transform.position, neck.transform.position) * (15.0f / 20.85f)).ToString();
            line.SetPosition(0, transform.position);
            line.SetPosition(1, neck.transform.position);
        }
		
	}
}
