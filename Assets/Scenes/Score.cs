using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance;
    [SerializeField] private TextMeshProUGUI scoreAtual;
    [SerializeField] private TextMeshProUGUI maiorScore;
    
    private int _score;
    
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    private void Start()
    {
        scoreAtual.text = _score.ToString();
        maiorScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        UpdateMaiorScore();
    }

    private void UpdateMaiorScore()
    {
        if (_score > PlayerPrefs.GetInt("HighScore")){
            PlayerPrefs.SetInt("HighScore", _score);
            maiorScore.text = _score.ToString();
        }
    }

    public void updateScore()
    {
        _score++;
        scoreAtual.text = _score.ToString();
        UpdateMaiorScore();
    }
}
