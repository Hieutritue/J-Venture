
using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SavePlayerPref : MonoBehaviour
{
        
      public static void Save(int level)
      {
          PlayerPrefs.SetInt("level", level);
          
      }

      public static void IncreaseDeath()
      {
           int deathNum = PlayerPrefs.GetInt("deathNum");
           deathNum++;
           PlayerPrefs.SetInt("deathNum",deathNum);
           Debug.Log("New Death Score:" + PlayerPrefs.GetInt("deathNum")); 
      }
      
      public static void Load()
      {
          
      }

      public static void Reset()
      {
          PlayerPrefs.DeleteAll();
      }
}
