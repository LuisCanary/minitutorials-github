using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine;

public class ExitCar : MonoBehaviour {

    public GameObject carCam;
    public GameObject thePlayer;
    public GameObject exitTrigger;
    public GameObject theCar;

    public GameObject exitPlace;

    private void Update()
    {
        if (Input.GetButtonDown("Action"))
        {
            thePlayer.SetActive(true);
            thePlayer.transform.position = exitPlace.transform.position;
            carCam.SetActive(false);
            theCar.GetComponent<CarController>().enabled = false;
            theCar.GetComponent<CarUserControl>().enabled = false;
            exitTrigger.SetActive(false);

        }
    }
}
