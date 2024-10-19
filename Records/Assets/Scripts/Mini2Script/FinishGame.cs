using UnityEngine;

public class FinishGame : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("A pipa é gente boa");
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Vai se fuder pipa");
        }
    }
}
