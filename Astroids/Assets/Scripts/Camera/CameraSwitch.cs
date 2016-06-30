using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour {

    public Camera MainCamera;
    public Camera Camera1;
    public Camera Camera2;

	// Use this for initialization
	void Start () {
        
       MainCamera.enabled = true;
        Camera1.enabled = false;
        Camera2.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.E))
        {
            MainCamera.enabled = !MainCamera.enabled;
            Camera1.enabled = !Camera1.enabled;
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Camera1.enabled = !Camera1.enabled;
            Camera2.enabled = !Camera2.enabled;
        }

	
	}
}
