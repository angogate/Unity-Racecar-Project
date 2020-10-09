using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public Text endGameDisplay;
    private int cpuLaps;
    private int playerLaps;

    // Start is called before the first frame update
    void Start()
    {
        endGameDisplay = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        playerLaps = CheckpointTracker.numLaps;
        cpuLaps = CheckPointTrackerCPU.numLapsCPU;
        if (playerLaps == 2)
        {
            Time.timeScale = 0;
            endGameDisplay.text = "You won!";
        }
        else if (cpuLaps == 2 && playerLaps < 2)
        {
            Time.timeScale = 0;
            endGameDisplay.text = "The CPU won and you lost!";
        }
    }
}
