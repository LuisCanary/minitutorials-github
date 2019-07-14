using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperScope : MonoBehaviour {

    public GameObject playerCam;
    public GameObject sniperScope;
	
	
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            playerCam.GetComponent<Camera>().fieldOfView = 30;
            sniperScope.SetActive(true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            playerCam.GetComponent<Camera>().fieldOfView = 60;
            sniperScope.SetActive(false);
        }

    }
}
