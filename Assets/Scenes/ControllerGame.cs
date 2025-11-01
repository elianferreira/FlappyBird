using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerGame : MonoBehaviour
{
    // Start is called before the first frame update
    
    public static ControllerGame Instance;
    [SerializeField] private GameObject gameOverPanel;
    
    public void StartGame()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        ControllerGame.Instance.GameOver();
    }
}
