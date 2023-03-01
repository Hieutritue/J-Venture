using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] float transitionDelay = 3.0f;

    void Start()
    {
        anim = GameObject.Find("Transition").GetComponent<Animator>();
        
    }

    // Update is called once per frame
    public void NextLevel()
    {
        StartCoroutine(DelayedTransition(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void ReloadCurrentLevel()
    {
        float checkpoint_x = PlayerPrefs.GetFloat("checkpoint_x", 3f);
        float checkpoint_y = PlayerPrefs.GetFloat("checkpoint_y", 3f);
        float checkpoint_z = PlayerPrefs.GetFloat("checkpoint_z", 3f);

        // Di chuyển người chơi đến checkpoint đó
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = new Vector3(checkpoint_x, checkpoint_y, checkpoint_z);
        StartCoroutine(DelayedTransition(SceneManager.GetActiveScene().buildIndex));
    }

    IEnumerator DelayedTransition(int index)
    {
        anim.SetTrigger("triggertransition");

        yield return new WaitForSeconds(transitionDelay); // cho mot chut roi moi chay scene moi

        SceneManager.LoadScene(index);
    }
}