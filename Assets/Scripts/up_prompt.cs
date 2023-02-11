using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class up_prompt : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject db_up;
    public GameObject tb_up;
    public GameObject ship_up;
    public GameObject fr_up;
    

    void Start()
    {
        db_up.SetActive(false);
        tb_up.SetActive(false);
        ship_up.SetActive(false);
        fr_up.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreScript.myScore >= 500f)
        {
            db_up.SetActive(true);
        }

        if (ScoreScript.myScore >= 500f && Input.GetKeyDown(KeyCode.E))
        {
            db_up.transform.localScale = Vector2.zero;
        } 
        
        if (ScoreScript.myScore >= 1500f )
        {
            tb_up.SetActive(true);
        }

        if (ScoreScript.myScore >= 1500f && Input.GetKeyDown(KeyCode.E))
        {
            tb_up.transform.localScale = Vector2.zero;

        }

        if (ScoreScript.myScore >= 3000f)
        {
            ship_up.SetActive(true);
        }

        if (ScoreScript.myScore >= 3000f && Input.GetKeyDown(KeyCode.E))
        {
            ship_up.transform.localScale = Vector2.zero;

        }

        if (ScoreScript.myScore >= 6000f)
        {
            fr_up.SetActive(true);
        }

        if (ScoreScript.myScore >= 6000f && Input.GetKeyDown(KeyCode.E))
        {
            fr_up.transform.localScale = Vector2.zero;

        }
    }
}
