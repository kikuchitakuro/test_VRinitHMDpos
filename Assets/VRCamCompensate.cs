using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


public class VRCamCompensate : MonoBehaviour {

	// Use this for initialization
	void Start () {
        InputTracking.Recenter();
    }

    /*
    // Update is called once per frame
    int count = 0;
	void Update () {
        if (count < 30) {
            //Vector3 pos = InputTracking.GetLocalPosition(XRNode.CenterEye);
            //transform.position = -pos;
            //Debug.Log(pos);
            
            /*
            Quaternion rot = InputTracking.GetLocalRotation(XRNode.CenterEye);
            float xrot = rot.eulerAngles.x;
            float yrot = rot.eulerAngles.y;
            float zrot = rot.eulerAngles.z;
            //transform.localEulerAngles = new Vector3(-xrot,-yrot,-zrot);
        }
        count += 1;
    }
    */
}
