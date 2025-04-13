using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameSession : MonoBehaviour
{
    [SerializeField] int playerLives = 1;
    [SerializeField] int score = 0;

    [SerializeField] TextMeshProUGUI livesText;
    [SerializeField] TextMeshProUGUI scoreText;
    
    void Awake()
    {
        
        int numGameSessions = FindObjectsOfType<GameSession>().Length;
        Debug.Log(">>>>>>" + numGameSessions);
        if (numGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start() 
    {
        Debug.Log(">>>>>>playerLives: " + playerLives);
        livesText.text = playerLives.ToString();
        scoreText.text = score.ToString();    
    }
    public void ProcessPlayerDeath() // xu li cai chet player
    {
        if (playerLives > 1)
        {
            TakeLife();
        }
        else
        {
            
            ResetGameSession();
        }
    }
    public void AddToScore(int pointsToAdd)
    {
        score += pointsToAdd;
        scoreText.text = score.ToString(); 
    }
    void TakeLife()
    {
        playerLives--;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        livesText.text = playerLives.ToString();
    }
    //void ResetGameSession()
    //{
    //    FindObjectOfType<ScenePersist>().ResetScenePersist();
    //    SceneManager.LoadScene(5);
    //    Destroy(gameObject);
    //}
    void ResetGameSession()
    {
        FindObjectOfType<ScenePersist>().ResetScenePersist();
        StartCoroutine(WaitAndReset());
    }

    IEnumerator WaitAndReset()
    {
        yield return new WaitForSeconds(1.2f); // doi 2 giay

        SceneManager.LoadScene(6);
        Destroy(gameObject);
    }
}
