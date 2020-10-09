using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoroutineForStartOfGame : MonoBehaviour
{
    public Text input;
    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<Text>();
        StartCoroutine(CoroutineStart());
    }

    // Update is called once per frame
    IEnumerator CoroutineStart()
    {
        input.text = "On your marks";
        yield return new WaitForSeconds(0.2f);
        input.text = "Get set";
        yield return new WaitForSeconds(0.2f);
        input.text = "GO!";
        yield return new WaitForSeconds(0.2f);
        input.text = "";
    }
}
