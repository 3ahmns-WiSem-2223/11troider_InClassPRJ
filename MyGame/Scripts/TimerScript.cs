using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float time = 20.0f;
    [SerializeField] Text timerText;
    public bool gameEnded;

    private void Update()
    {

        time -= Time.deltaTime;

        if (time <= 0.0f)
        {
            timerEnded();
        }
        timerText.text = ("" + (int)time);
    }

    void timerEnded()
    {
        Debug.Log("timerended");
        gameEnded = true;
    }


}
