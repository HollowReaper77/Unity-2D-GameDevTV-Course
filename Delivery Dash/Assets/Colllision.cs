using UnityEngine;

public class Colllision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
    }
}
