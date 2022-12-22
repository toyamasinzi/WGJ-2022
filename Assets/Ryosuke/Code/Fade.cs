using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    [Header("フェイドのための色"), Tooltip("フェイドカラー")]
    public float _fadeSpeed = 2.0f;
    float r, g, b, a;


    bool isFadeOut = false;
    Image fadePanel;

    private void Start()
    {
        fadePanel = GetComponent<Image>();

        r = fadePanel.color.r;
        g = fadePanel.color.g;
        b = fadePanel.color.b;
        a = fadePanel.color.a;
    }

    private void Update()
    {
        if (isFadeOut)
        {
            FadeIn();
        }
    }

    private void FadeIn()
    {
        a += _fadeSpeed;
        fadePanel.color = new Color(r, g, b, a);

        if (a >= 1)
        {
            isFadeOut = false;
        }


    }
}
