using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirCheckAnswer : MonoBehaviour
{
    public Toggle o_Toggle;
    public Toggle t_Toggle;
    public Toggle th_Toggle;
    public Toggle fo_Toggle;
    public Toggle fi_Toggle;

    public GameObject rightText;
    public GameObject wrongText;

    public void CorrectTheAnswer()
    {
        if (o_Toggle.isOn && t_Toggle.isOn && th_Toggle.isOn && !fo_Toggle.isOn && fi_Toggle.isOn)
        {
            // Debug.Log("Bingo");
            rightText.SetActive(true);
        }
        else
        {
            // Debug.Log("Not Bingo");
            wrongText.SetActive(true);
        }
    }
}

