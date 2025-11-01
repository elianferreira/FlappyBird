using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCano : MonoBehaviour
{
    [SerializeField] private float velocidade = 0.65f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * (velocidade * Time.deltaTime);
    }
}
