using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            //Debug.Log(currentLevel);
           // Vector2 checkpointPosition = checkpoints[currentLevel];
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            //player.transform.position = checkpointPosition;
        }
    }
}
