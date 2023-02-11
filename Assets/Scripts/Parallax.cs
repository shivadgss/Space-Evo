using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    public float backGroudSpeed;
    public Renderer backgroundRenderer;

    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backGroudSpeed * Time.deltaTime, 0f);
    }
}
