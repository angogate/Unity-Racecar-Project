using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayLaps : MonoBehaviour
{
    public Text lapDisplay;
    private int lapNumber;
    // Start is called before the first frame update
    void Start()
    {
        lapDisplay = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        lapNumber = CheckpointTracker.numLaps;
        lapDisplay.text = "Lap " + lapNumber.ToString() + " / 2";
    }
}
