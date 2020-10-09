using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplaySpeed : MonoBehaviour
{
    public Rigidbody car;
    public Text speedDisplay;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        speedDisplay = GetComponent<Text>();
        speedDisplay.text = "Speed - 0 mi/hr";
    }

    // Update is called once per frame
    void Update()
    {
        speed = (int)car.velocity.magnitude;
        speedDisplay.text = "Speed - " + speed.ToString() + " mi/hr";
    }
}
