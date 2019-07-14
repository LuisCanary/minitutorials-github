using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour {

    public float theDistance;
    public GameObject theCursor;
    public GameObject theText;
    public bool hasPlayed;
	void Update ()
    {
        theDistance = PlayerCasting.DistanceFromTarget;
		
	}
    private void OnMouseOver()
    {
        if (theDistance<=3)
        {
            if (hasPlayed==false)
            {
                theCursor.GetComponent<Animation>().Play("OpenUp");
                hasPlayed = true;
            }
           
            theText.SetActive(true);
        }
    }
    void OnMouseExit()
    {
        theCursor.GetComponent<Animation>().Play("CloseDown");
        theText.SetActive(false);
        hasPlayed = false;
    }
}
