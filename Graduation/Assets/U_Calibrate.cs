using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class U_Calibrate : MonoBehaviour
{

    public GameObject target;
    public GameObject tip;
    public GameObject plane;
    public GameObject cyclinder;

    void Start()
    {
        target.transform.position = this.gameObject.transform.position;


    }

    // Update is called once per frame
    void Update()
    {

        //Debug.DrawRay(transform.position, (tip.transform.position- transform.position), Color.green);

        if (Input.GetKeyDown(KeyCode.C) && tip.GetComponent<Line_to_Neck>().tip_ready)
        {
            tip.GetComponent<Line_to_Neck>().neck_ready = true;
            target.transform.position = GameObject.Find("Calibration_Target").transform.position;
            plane.SetActive(true);
            cyclinder.SetActive(true);

        }
        if (plane.gameObject.active)
        {
            plane.transform.rotation = this.transform.rotation;
        }
    }
}
