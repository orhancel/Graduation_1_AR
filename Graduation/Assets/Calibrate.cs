using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calibrate : MonoBehaviour {
    public GameObject tip;
    public GameObject plane;
    //public GameObject destination;
    // Use this for initialization
    GUIStyle style=new GUIStyle();
    LineRenderer line;
    //public Vector3 pos_tempX;
    Vector3 size_temp;
    
    void OnGUI()
    {       // *   (10.0f/ 13.8f)
        GUI.Label(new Rect(10, 10, 100, 50), (Vector3.Distance(transform.position, tip.transform.position)* (15.0f / 20.85f)).ToString(), style);
            
       
    }
        
    void Start () {
        tip.transform.position = this.gameObject.transform.position; 
        style.normal.textColor = Color.red;
        line = GetComponent<LineRenderer>();
    }
	
	// Update is called once per frame
	void Update () {

        //Debug.DrawRay(transform.position, (tip.transform.position- transform.position), Color.green);
        line.SetPosition(0, transform.position);
        line.SetPosition(1, tip.transform.position);
        if (Input.GetKeyDown(KeyCode.N))
        {
            
            tip.transform.position= GameObject.Find("Calibration_Target").transform.position;
            tip.GetComponent<Line_to_Neck>().tip_ready = true;
            //plane.transform.position = Vector3.Lerp(transform.position, tip.transform.position, 0.5f);
            //tip.transform.position = transform.position;
            //Vector3 middle = Vector3.Lerp(transform.position, tip.transform.position, 0.5f);
            /* size_temp = tip.transform.localScale;
             size_temp.z = (destination.transform.position - transform.position).magnitude/2.0f;
             tip.transform.LookAt(destination.transform.position);
             tip.transform.position = middle;
             tip.transform.localScale = size_temp;*/



        }
	}
}
