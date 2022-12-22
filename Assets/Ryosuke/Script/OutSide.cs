using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutSide : MonoBehaviour
{
    [Serializable]
    class ChangeSetting
    {
        public string Scene;
    }
    
    [SerializeField] List<ChangeSetting> Setting;

    private void Awake()
    {
        
        Setting.ForEach(s =>
        {
            SceneManager.LoadScene(s.Scene);
           
        });
    }
}
