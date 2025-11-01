using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentarPontuacao : MonoBehaviour
{
    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     if (collision.gameObject.CompareTag("Player"))
    //     {
    //       Score.instance.updateScore();
    //     }
    // }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"[AumentarPontuacao] Trigger com: {other.name}");
        if (other.CompareTag("Player"))
        {
            if (Score.instance == null)
            {
                Debug.LogError("Score.instance == null");
            }
            else
            {
                Score.instance.updateScore();
                Debug.Log("[AumentarPontuacao] +1 ponto");
            }
        }
    }
}
