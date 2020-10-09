using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUCarMovement : MonoBehaviour
{
    public GameObject CPUCheckpoint;
    public GameObject Second;
    public GameObject Third;
    public GameObject Fourth;
    public GameObject Fifth;
    public GameObject Sixth;
    public GameObject Seventh;
    public GameObject Eighth;
    public GameObject Ninth;
    public GameObject Tenth;
    public GameObject Eleventh;
    public GameObject Twelfth;
    public GameObject Thirteenth;
    public GameObject Fourteenth;
    public GameObject Fifteenth;
    public GameObject Sixteenth;
    public GameObject Second_2;
    public GameObject Third_2;
    public GameObject Fourth_2;
    public GameObject Fifth_2;
    public GameObject Sixth_2;
    public GameObject Seventh_2;
    public GameObject Eighth_2;
    public GameObject Ninth_2;
    public GameObject Tenth_2;
    public GameObject Eleventh_2;
    public GameObject Twelfth_2;
    public GameObject Thirteenth_2;
    public GameObject Fourteenth_2;
    public GameObject Fifteenth_2;
    public GameObject Sixteenth_2;
    public GameObject SecondCPU;

    public GameObject[] gameObjects;
    
    public int numTrack;
    
    public bool check;


    void Start()
    {
        gameObjects = new GameObject[] { CPUCheckpoint, Second, Third, Fourth, Fifth, Sixth, Seventh, Eighth, Ninth, Tenth, Eleventh, Twelfth, Thirteenth, Fourteenth, Fifteenth, Sixteenth, SecondCPU, Second_2 , Third_2, Fourth_2, Fifth_2, Sixth_2, Seventh_2, Eighth_2, Ninth_2, Tenth_2, Eleventh_2, Twelfth_2, Thirteenth_2, Fourteenth_2, Fifteenth_2, Sixteenth_2   };
    }

    void Update()
    {
        check = false;

        for (int i = 0; i < 32; i++)
        {
            if (numTrack == i)
            {
                gameObjects[0].transform.position = gameObjects[i].transform.position;
                transform.LookAt(gameObjects[i].transform.position);
            }
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if (check == true)
        {
            return;
        }

        check = true;

        if (c.gameObject.tag == "CPUCar")
        {
            numTrack++;
        }
    }
}
