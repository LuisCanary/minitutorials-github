using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    //To use this script we have to attach it to some object for example
    //And make buttons or something that use the methods of saving and loading

    public float level = 15;
    public float health = 20;
    Transform position ;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Save"))
        {
            SavePlayer();
        }
        else if (other.CompareTag("Load"))
        {
           LoadPlayer();
        }
    }
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);//We can access the method because is static 
    }

    public void LoadPlayer()
    {
       PlayerData data= SaveSystem.LoadPlayer();

        level = data.level;
        health = data.health;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;


    }
}
