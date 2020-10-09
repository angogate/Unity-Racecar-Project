using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTracker : MonoBehaviour
{
    public GameObject Checkpoint1;
    public GameObject Checkpoint2;
    public GameObject Checkpoint3;
    public GameObject Checkpoint4;
    public GameObject Checkpoint5;
    public GameObject Checkpoint6;
    public GameObject Checkpoint7;
    public GameObject Checkpoint8;
    public GameObject startingLine;
    public static int numCheckpoints;
    public static int numLaps;

    void OnTriggerEnter(Collider c)
    {
        startingLine.SetActive(true);
        if (c.gameObject.name == "Checkpoint1") 
        {
            numCheckpoints++;
            Checkpoint1.SetActive(false);
        }

        if (c.gameObject.name == "Checkpoint2")
        {
            Checkpoint2.SetActive(false);
            numCheckpoints++;
        }
        if (c.gameObject.name == "Checkpoint3")
        {
            Checkpoint3.SetActive(false);
            numCheckpoints++;
        }
        if (c.gameObject.name == "Checkpoint4")
        {
            Checkpoint4.SetActive(false);
            numCheckpoints++;
        }
        if (c.gameObject.name == "Checkpoint5")
        {
            Checkpoint5.SetActive(false);
            numCheckpoints++;
        }
        if (c.gameObject.name == "Checkpoint6")
        {
            Checkpoint6.SetActive(false);
            numCheckpoints++;
        }
        if (c.gameObject.name == "Checkpoint7")
        {
            Checkpoint7.SetActive(false);
            numCheckpoints++;
        }
        if (c.gameObject.name == "Checkpoint8")
        {
            Checkpoint8.SetActive(false);
            numCheckpoints++;
        }

        if (numCheckpoints == 8 && c.gameObject.name == "Starting Line")
        {
            startingLine.SetActive(false);
            Checkpoint1.SetActive(true);
            Checkpoint2.SetActive(true);
            Checkpoint3.SetActive(true);
            Checkpoint4.SetActive(true);
            Checkpoint5.SetActive(true);
            Checkpoint6.SetActive(true);
            Checkpoint7.SetActive(true);
            Checkpoint8.SetActive(true);
            numCheckpoints = 0;
            numLaps++;
        }
    }
}
