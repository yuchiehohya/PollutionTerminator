using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WaterStar : MonoBehaviour
{
    public GameObject starOne;
    public GameObject starTwo;
    public GameObject starThree;
    public GameObject textToNextPlace;
    // public GameObject blueHouse;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FinishSection();
    }
    public void FinishSection()
    {

        if (starOne.activeSelf && starTwo.activeSelf && starThree.activeSelf)
        {
            // blueHouse.SetActive(false);
            textToNextPlace.SetActive(true);
            
        }
    }
}
