using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

   public GameObject CamOn, CamOff;

    private void OnTriggerEnter(Collider other)
    {
        CamOn.SetActive(true);
        CamOff.SetActive(false);
    }

}
