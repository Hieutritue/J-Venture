using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    public class PlayerPos : MonoBehaviour
    {
        private SaveCheckpoint scp;

        void Start()
        {
            scp = GameObject.FindGameObjectWithTag("savedCheckpoint").GetComponent<SaveCheckpoint>();
            if (SceneManager.GetActiveScene().buildIndex == scp.level)
            {
               transform.position = scp.lastCheckpointPos; 
            }
            else
            {
                scp.lastCheckpointPos = transform.position;
                scp.level = SceneManager.GetActiveScene().buildIndex;
            }
            
        }
    }
