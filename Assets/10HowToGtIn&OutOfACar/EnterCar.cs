using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine;

public class EnterCar : MonoBehaviour {

    public GameObject carCam;
    public GameObject thePlayer;
    public GameObject exitTrigger;
    public GameObject theCar;

    bool triggerCheck;


    private void Update()
    {
        if (triggerCheck)
        {
            if (Input.GetButtonDown("Action"))
            {
                carCam.SetActive(true);
                thePlayer.SetActive(false);
                theCar.GetComponent<CarController>().enabled = true;
                theCar.GetComponent<CarUserControl>().enabled = true;
                exitTrigger.SetActive(true);

            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        triggerCheck = true;
    }
    private void OnTriggerExit(Collider other)
    {
        triggerCheck = false;
    }
}
