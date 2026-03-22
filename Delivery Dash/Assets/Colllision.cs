using UnityEngine;

public class Colllision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D()
    {
        Debug.Log("What the heck was that?");
    }
}
