using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterScript : MonoBehaviour
{
    public int counterInt;
    [SerializeField] Text counterText;

    private void Update()
    {
        
        counterText.text = (""+counterInt);
    }
}
