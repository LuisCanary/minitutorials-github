using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=XOjd_qU2Ido&index=1&list=WL

[System.Serializable]//In order to save it in a file
public class PlayerData {//It don't have to be a monobehabiour script 

    public float level;
    public float health;
    public float[] position;//we have the same as in the player script

    public PlayerData(Player player)//we create a method to save those values
    {
        level = player.level;
        health = player.health;

        position = new float[3];//We can't save a vector 3 so we save the three values in  and array of floats
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;

    }
	
}
