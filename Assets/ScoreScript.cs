using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreScript : MonoBehaviour
{
    public int playScore;
    public Text score;
    public GameObject gameOverText;
    [ContextMenu("Increase score")]
    public void addScore(){
        playScore += 1;
        score.text = playScore.ToString();
    }
    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver(){
        gameOverText.SetActive(true);
    }
}
