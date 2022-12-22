using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public string _sceneName;

    private void Start()
    {
        SceneManager.LoadScene(_sceneName);
    }

}
