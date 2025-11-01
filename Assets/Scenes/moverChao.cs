using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverChao : MonoBehaviour
{
    [SerializeField] private float velocidade = 1f;
    [SerializeField] private float largura = 6f;
    private SpriteRenderer _spriteRenderer;
    private Vector2 _startSize;
    
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _startSize = new Vector2(_spriteRenderer.size.x,  _spriteRenderer.size.y);
    }

    // Update is called once per frame
    void Update()
    {
        _spriteRenderer.size = new Vector2(_spriteRenderer.size.x + velocidade * Time.deltaTime, _spriteRenderer.size.y);

        if (_spriteRenderer.size.x > largura)
        {
            _spriteRenderer.size = _startSize;
        }
           

    }
}
