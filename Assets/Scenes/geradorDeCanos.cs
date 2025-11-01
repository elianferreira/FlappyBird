using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geradorDeCanos : MonoBehaviour
{
    [SerializeField] private float tempoMaximo = 1.5f;
    [SerializeField] private float altura      = 0.45f;
    [SerializeField] private GameObject cano;

    private float timer;
    
    void Start()
    {
        SpawnDeCanos();
    }
    
    void Update()
    {
        if (timer > tempoMaximo)
        {
            SpawnDeCanos();
            timer = 0;
        }
        
        timer += Time.deltaTime;
    }

    void SpawnDeCanos()
    {
        Vector3 spawnPosition = transform.position + new Vector3(0, Random.Range(-altura, altura));
        GameObject _cano = Instantiate(cano, spawnPosition, Quaternion.identity);
        Destroy(_cano, 10f);
    }
}
