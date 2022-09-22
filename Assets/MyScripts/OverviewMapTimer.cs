using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverviewMapTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;
    public bool isRunning = false;

    public Text timerText;

    private void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            currentTime -= 1 * Time.deltaTime;
            timerText.text = currentTime.ToString("0");

            if (currentTime <= 0)
            {
                currentTime = 0;
                timerText.text = "E";
                currentTime = 10;
            }

        }
    }
}
