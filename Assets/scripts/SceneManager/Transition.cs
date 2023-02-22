using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Transition : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] float transitionDelay = 1.0f;
    void Start()
    {
        anim = GameObject.Find("Transition").GetComponent<Animator>();
    }

    // Update is called once per frame
    public void NextLevel()
    {
        StartCoroutine(DelayedTransition(SceneManager.GetActiveScene().buildIndex+1));
    }
    public void ReloadCurrentLevel()
    {
        StartCoroutine(DelayedTransition(SceneManager.GetActiveScene().buildIndex));
    }
    IEnumerator DelayedTransition(int index)
    {
        anim.SetTrigger("triggertransition");
        yield return new WaitForSeconds(transitionDelay);
        SceneManager.LoadScene(index);
        
    }
}
