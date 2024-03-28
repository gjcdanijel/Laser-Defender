using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int currentScore = 0;

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
