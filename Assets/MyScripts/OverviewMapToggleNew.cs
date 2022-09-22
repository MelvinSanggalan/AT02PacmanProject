using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverviewMapToggleNew : MonoBehaviour
{
    public GameObject overviewMap;
    float uptimeDuration = 5f;
    float cooldownDuration = 10f;
    bool isCooldown = false;

    public OverviewMapTimer overviewMapTimer;


    void Start()
    {
        overviewMap.SetActive(false);
        overviewMapTimer = GetComponent<OverviewMapTimer>();
        
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && isCooldown == false)
        {
            isCooldown = true;
            StartCoroutine(Cooldown());
        }

    }

    IEnumerator Cooldown()
    {
        overviewMap.SetActive(true);
        yield return new WaitForSeconds(uptimeDuration);
        overviewMap.SetActive(false);
        overviewMapTimer.isRunning = true;

        yield return new WaitForSeconds(cooldownDuration);
        isCooldown = false;
        overviewMapTimer.isRunning = false;

    }
}
