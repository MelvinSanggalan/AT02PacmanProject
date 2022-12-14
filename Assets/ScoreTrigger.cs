using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTrigger : MonoBehaviour
{
    public Text textRef;
    public int scoreValue = 5;

    //The value of a static variable is shared between all instance
    //of a class. In this case, all instances oif the ScoreTrigger script
    //will share the same value for this variable.
    private static int currentScore = 0;

    private void Awake()
    {
        if (currentScore > 0)
        {
            currentScore = 0;
        }
        textRef.text = "Score : " + currentScore;

    }

    /// <summary>
    /// OnTriggerEnter is called on the frame when a foreign collider enters this collider.
    /// A reference to the foreign collider is stored within the 'other' parameter.
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") == true)
        {
            currentScore += scoreValue;
            textRef.text = "Score : " + currentScore;
        }
    }
}
