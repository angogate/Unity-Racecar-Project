using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointTrackerCPU : MonoBehaviour
{
    public GameObject cpuCar;
    public GameObject Checkpoint1CPU;
    public GameObject Checkpoint2CPU;
    public GameObject Checkpoint3CPU;
    public GameObject Checkpoint4CPU;
    public GameObject Checkpoint5CPU;
    public GameObject Checkpoint6CPU;
    public GameObject Checkpoint7CPU;
    public GameObject Checkpoint8CPU;
    public GameObject startingLineCPU;
    public static int numCheckpointsCPU;
    public static int numLapsCPU;

    void OnTriggerEnter(Collider c)
    {
        startingLineCPU.SetActive(true);
        if (c.gameObject.name == "Checkpoint1CPU")
        {
            Checkpoint1CPU.SetActive(false);
            numCheckpointsCPU++;
        }
        if (c.gameObject.name == "Checkpoint2CPU")
        {
            Checkpoint2CPU.SetActive(false);
            numCheckpointsCPU++;
        }
        if (c.gameObject.name == "Checkpoint3CPU")
        {
            Checkpoint3CPU.SetActive(false);
            numCheckpointsCPU++;
        }
        if (c.gameObject.name == "Checkpoint4CPU")
        {
            Checkpoint4CPU.SetActive(false);
            numCheckpointsCPU++;
        }
        if (c.gameObject.name == "Checkpoint5CPU")
        {
            Checkpoint5CPU.SetActive(false);
            numCheckpointsCPU++;
        }
        if (c.gameObject.name == "Checkpoint6CPU")
        {
            Checkpoint6CPU.SetActive(false);
            numCheckpointsCPU++;
        }
        if (c.gameObject.name == "Checkpoint7CPU")
        {
            Checkpoint7CPU.SetActive(false);
            numCheckpointsCPU++;
        }
        if (c.gameObject.name == "Checkpoint8CPU")
        {
            Checkpoint8CPU.SetActive(false);
            numCheckpointsCPU++;
        }

        if (numCheckpointsCPU == 8 && c.gameObject.name == "Starting Line CPU")
        {
            startingLineCPU.SetActive(false);
            Checkpoint1CPU.SetActive(true);
            Checkpoint2CPU.SetActive(true);
            Checkpoint3CPU.SetActive(true);
            Checkpoint4CPU.SetActive(true);
            Checkpoint5CPU.SetActive(true);
            Checkpoint6CPU.SetActive(true);
            Checkpoint7CPU.SetActive(true);
            Checkpoint8CPU.SetActive(true);
            numCheckpointsCPU = 0;
            numLapsCPU++;
        }
    }
}
