using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI myScoreText;
    public static float myScore = 0f;
    // Start is called before the first frame update
    void Start()
    {
        myScore = 0f;
        myScoreText = GetComponent<TextMeshProUGUI>();
        myScoreText.text = "0";
    }

    private void Update()
    {
        myScoreText.text = "Score : " + myScore;
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            myScore += 5 * Time.deltaTime;
            myScoreText.text = ((int)myScore).ToString();

        }
    }


    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ResetScore()
    {
        myScore = 0f;
    }

}
