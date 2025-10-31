using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] private float velocidade = 1.5f;
    private Rigidbody2D rb;
    
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rb.velocity = Vector2.up * velocidade;
        }
    }
}
