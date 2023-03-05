
using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SavePlayerPref : MonoBehaviour
{
        
      public static void Save(int level)
      {
        if(level!=0)
        {
            PlayerPrefs.SetInt("level", level);
        } 
      }

    // public static void SaveTimePlayed(float timePlayed)
    // {
    //     PlayerPrefs.SetFloat("Level3_TimePlayed", timePlayed);
    // }

    public static void IncreaseDeath()
    {
        int deathNum = PlayerPrefs.GetInt("deathNum");
        deathNum++;
        PlayerPrefs.SetInt("deathNum", deathNum);
        Debug.Log("New Death Score:" + PlayerPrefs.GetInt("deathNum"));

        // //Lưu thời gian đã chơi khi người chơi chết

        // float timePlayed =PlayerPrefs.GetFloat("Level3_TimePlayed");
        // timePlayed=Time.time;
        // PlayerPrefs.SetFloat("Level3_TimePlayed", timePlayed);
        // Debug.Log("Time played: " + PlayerPrefs.GetFloat("Level3_TimePlayed"));
        // // SaveTimePlayed(timePlayed);
    }


    public static void Reset()
    {
        PlayerPrefs.DeleteAll();
    }

}
