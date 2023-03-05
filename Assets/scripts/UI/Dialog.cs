using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Dialog : MonoBehaviour
{   
    [SerializeField] AudioSource typeSFX;
    [SerializeField] AudioSource winSFX;
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    public float typingSpeed;
    private int index;

    public GameObject continueButton;
    public GameObject EGImage;
    [SerializeField] TextMeshProUGUI deathCount;
    [SerializeField] GameObject deathCountObject;
    int sentenceCount=0;
    bool ended=false;
    float timer=0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Type());
        deathCount.text = PlayerPrefs.GetInt("deathNum").ToString() + " lần";
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
        if(ended)
        {
            timer+=Time.deltaTime;
            if(timer>=10f)
                {
                    SavePlayerPref.Reset();
                    Application.Quit();
                    Debug.Log("quit");
                }
        }
    }
    IEnumerator Type()
    {   typeSFX.Play();
        foreach (char c in sentences[index].ToCharArray())
        {
            textDisplay.text +=c;
            yield return new WaitForSeconds(typingSpeed);
        }
        typeSFX.Stop();
        if(sentenceCount==1)
        {
             deathCountObject.SetActive(true);
        }
        sentenceCount++;
    }
    public void NextSentence()
    {
        continueButton.SetActive(false);
        if(index < sentences.Length - 1){
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
           
        }
        else 
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            EGImage.SetActive(true);
            winSFX.Play();
            Debug.Log("Image enabled");
            ended=true;
        }
    }
}
