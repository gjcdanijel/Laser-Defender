using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreKeeper : MonoBehaviour
{
    int currentScore = 0;

    static ScoreKeeper instance;
    // public ScoreKeeper GetInstance()
    // {
    //     return instance;
    // }
    void Awake()
    {
        ManageSingleton();
    }
    void ManageSingleton()
    {
        if (instance != null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public int GetScore()
    {
        return currentScore;
    }
    public void AddScore(int scorePointToAdd)
    {
        currentScore += scorePointToAdd;
        Mathf.Clamp(currentScore, 0, int.MaxValue);
        Debug.Log(currentScore);
    }
    public void SetScore(int score)
    {
        currentScore = score;
    }
    public void ResetScore()
    {
        currentScore = 0;
    }
}
