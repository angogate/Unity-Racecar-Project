using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCheckpoints : MonoBehaviour
{
    public Text checkPointDisplay;
    private int numCheckpoints;
    // Start is called before the first frame update
    void Start()
    {
        checkPointDisplay = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        numCheckpoints = CheckpointTracker.numCheckpoints;
        checkPointDisplay.text = "Checkpoint " + numCheckpoints.ToString() + " / 8";
        if (numCheckpoints == 0)
        {
            checkPointDisplay.text = "Checkpoint 0 / 8";
        }
    }
}
