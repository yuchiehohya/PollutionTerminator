using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TwoStars : MonoBehaviour
{
    public GameObject starOne;
    public GameObject starTwo;
    public GameObject textToNextPlace;
    
    AudioSource bingoAudio;

    void Start()
    {
        bingoAudio = GetComponent<AudioSource>();
        // Debug.Log(starOne.activeSelf);
        // Debug.Log(starTwo.activeSelf);
    }

    void Update()
    {
        FinishSection();
    }
    
    
    
    public void FinishSection()
    {

        if (starOne.activeSelf && starTwo.activeSelf)
        {
            textToNextPlace.SetActive(true);
           
        }
    }

}
