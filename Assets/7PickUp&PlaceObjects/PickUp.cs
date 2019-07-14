using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

   public Transform OnHand;

    //To pickup an object he needs the script and in the public field put the gameobject
    //In this case our hand, that is inside the FPS
    private void OnMouseDrag()
    {
        GetComponent<Rigidbody>().useGravity = false;
        transform.position = OnHand.position;
        transform.parent = GameObject.Find("FPSController").transform;
        transform.parent = GameObject.Find("FirstPersonCharacter").transform;
    }
    private void OnMouseOver()
    {
      this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
    }


}
