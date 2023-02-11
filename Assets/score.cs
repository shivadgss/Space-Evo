using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public float points = 0f;

    //public int newint;
    public TextMeshProUGUI scoretext;
    // Start is called before the first frame update
    void Start()
    {
        points = (int)ScoreScript.myScore;
        
        scoretext.text = points.ToString();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
