using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;//This library is use to manage with files
using System.Runtime.Serialization.Formatters.Binary;//To change the values that we save in a binary way so it can't be modificated so easy as in AGE3

//Is static so it can't be instantiated, to not create multiple versions of our save system
public static class SaveSystem  {

	
    public static void SavePlayer(Player player)
    {

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.fun";//Set the path of the file and the .fun is the extension
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);//As we have the playerdata with the values we don't have to do anything more here

        formatter.Serialize(stream, data);//we pass the line and the data and this data is in playerdata, in the other script
        stream.Close();
    }

    public static PlayerData LoadPlayer()
    {
        SceneManager.LoadScene("GameScene");

        string path = Application.persistentDataPath + "/player.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);//Now we open it, we don't create it

          PlayerData data= formatter.Deserialize(stream) as PlayerData;//This traduces from binary and we save it in data
            stream.Close();//Must be close if not it can make errors
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);//If we can't find the data
            return null;
        }

    }


}
