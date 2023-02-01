using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public CounterScript counterScript;
    private void Start()
    {
        gameObject.transform.position = new Vector2(Random.Range(-11, 11),(Random.Range(-5,5)));
    }
    private void OnMouseDown()
    {
        gameObject.transform.position = new Vector2(Random.Range(-11, 11), (Random.Range(-5, 5)));
        counterScript.counterInt = counterScript.counterInt + 1;
    }
}
