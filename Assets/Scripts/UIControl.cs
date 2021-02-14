using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    [SerializeField]
    GameObject gameNameText;

    [SerializeField]
    GameObject gameOverText;

    [SerializeField]
    Text scoreText;

    [SerializeField]
    GameObject playButton;

    int score;

    /// <summary>
    /// Oyuna giriş yapınca ekrandaki textleri verir.
    /// </summary>
    void Start()
    {
        gameOverText.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(false);
    }

    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true);
        playButton.gameObject.SetActive(true);
    }
    /// <summary>
    /// Ekrandaki textleri oyunu başlatınca yok eder veya gösterir.
    /// </summary>
    public void GameStarted()
    {
        score = 0;
        gameNameText.gameObject.SetActive(false);
        playButton.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(false);
        ScoreUpdate();
    }

    /// <summary>
    /// Skor güncelleme işi yapar.
    /// </summary>
    void ScoreUpdate()
    {
        scoreText.text = "Score: " + score; 
    }

    /// <summary>
    /// Asteroid yok olunca +10 puan skor verir
    /// </summary>
    public void AsteroidDestroyed(GameObject asteroid)
    {
        switch (asteroid.gameObject.name[8])
        {
            case '1':
                score += 5;
                ScoreUpdate();
                break;
            case '2':
                score += 10;
                ScoreUpdate();
                break;
            case '3':
                score += 15;
                ScoreUpdate();
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
