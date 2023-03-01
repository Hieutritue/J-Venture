
using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SavePlayerPref : MonoBehaviour
{
        
      public static void Save(int level)
      {
          PlayerPrefs.SetInt("level", level);
          
      }

    public static void SaveTimePlayed(float timePlayed)
    {
        PlayerPrefs.SetFloat("Level3_TimePlayed", timePlayed);
    }

    public static void IncreaseDeath()
    {
        int deathNum = PlayerPrefs.GetInt("deathNum");
        deathNum++;
        PlayerPrefs.SetInt("deathNum", deathNum);
        Debug.Log("New Death Score:" + PlayerPrefs.GetInt("deathNum"));

        // Lưu thời gian đã chơi khi người chơi chết
        float timePlayed = Time.time - PlayerPrefs.GetFloat("Level3_TimeStarted");
        Debug.Log("Time played: " + timePlayed);
        SaveTimePlayed(timePlayed);
    }


    public static void Reset()
    {
        PlayerPrefs.DeleteAll();
    }

}
