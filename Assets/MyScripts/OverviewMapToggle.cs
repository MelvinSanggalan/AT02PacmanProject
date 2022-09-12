using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverviewMapToggle : MonoBehaviour
{
    public GameObject overviewMap;


    // Start is called before the first frame update
    void Start()
    {
        overviewMap.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //If player clicks E and overview map is not active then
        if (Input.GetKeyDown(KeyCode.E) && (!overviewMap.activeSelf))
        {
            overviewMap.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.E) && (overviewMap.activeSelf))
        {
            overviewMap.SetActive(false);
        }


    }
}

