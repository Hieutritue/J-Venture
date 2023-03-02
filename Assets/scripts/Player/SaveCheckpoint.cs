using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector2 = System.Numerics.Vector2;

public class SaveCheckpoint : MonoBehaviour
    {
        private static SaveCheckpoint instance;
        public Vector3 lastCheckpointPos;
        public int level;
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                level = SceneManager.GetActiveScene().buildIndex;
                DontDestroyOnLoad(instance);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
