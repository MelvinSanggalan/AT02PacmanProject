using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialToggle : MonoBehaviour
{
    public Toggle selectedToggle;
    public GameObject tutorialScreen;

    private void Start()
    {
        selectedToggle.onValueChanged.AddListener(delegate {
            ToggleValueChangedOccured(selectedToggle);
            });
    }

    void ToggleValueChangedOccured(Toggle tglValue)
    {
        if(tglValue == tglValue.isOn)
        {
            tutorialScreen.SetActive(true);
        }
        else
        {
            tutorialScreen.SetActive(false);
        }
    }
}
