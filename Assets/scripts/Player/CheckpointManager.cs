using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    public static int currentLevel = 0;
    public static Dictionary<int, Vector2> checkpoints = new Dictionary<int, Vector2>();

    public static void SetCheckpoint(Vector2 checkpointPosition)
    {
        checkpoints[currentLevel] = checkpointPosition;
    }

    public static void LoadCheckpoint()
    {
        if (checkpoints.ContainsKey(currentLevel))
        {
            Debug.Log(currentLevel);
            Vector2 checkpointPosition = checkpoints[currentLevel];
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.transform.position = checkpointPosition;
        }
    }
}