using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            Debug.Log("abc");
            // Lưu checkpoint vị trí của người chơi bằng PlayerPrefs
            PlayerPrefs.SetFloat("checkpoint_x", transform.position.x);
            PlayerPrefs.SetFloat("checkpoint_y", transform.position.y);
            PlayerPrefs.SetFloat("checkpoint_z", transform.position.z);
            PlayerPrefs.Save();
        }
    }
}
