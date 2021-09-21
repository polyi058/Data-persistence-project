using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text player_name_field = GameObject.Find("NameText").GetComponent<Text>();
        if (MenuManager.Instance.PlayerName != null)
            player_name_field.text = "Name: " + MenuManager.Instance.PlayerName;

        Text highscore_field = GameObject.Find("ScoreText (1)").GetComponent<Text>();
        if (MainManager.Instance.HighScorePlayer != null)
            highscore_field.text = "Best Score : " + MainManager.Instance.HighScorePlayer + " : " + MainManager.Instance.HighScorePoints;
    }
}
