using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverviewMapOpenTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 5f;
    public bool isOpen = false;

    public Text timerText;

    private void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpen)
        {
            currentTime -= 1 * Time.deltaTime;
            timerText.text = currentTime.ToString("0");

            if (currentTime <= 0)
            {
                currentTime = 0;
                timerText.text = "5";
                currentTime = 5;
            }

        }
    }
}
