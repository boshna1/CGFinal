using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] float timer;
    [SerializeField] Text timeText;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Mathf.Round(timer);
        timeText.text = timer.ToString();
    }
}
