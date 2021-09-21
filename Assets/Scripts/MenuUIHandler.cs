using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
using TMPro;
#endif

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public void StartNew()
    {
        TMP_InputField player_name_field = GameObject.Find("InputFieldName").GetComponent<TMP_InputField>();
        MenuManager.Instance.PlayerName = player_name_field.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        // exit the application
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
            Application.Quit();
#endif
    }
}
