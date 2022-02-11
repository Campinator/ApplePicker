using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public static int Score = 0;


    void Awake()
    {
        //if high score is already saved, read it 
        if(PlayerPrefs.HasKey("ApplePickerHighScore")){
            Score = PlayerPrefs.GetInt("ApplePickerHighScore");
        }
        PlayerPrefs.SetInt("ApplePickerHighScore", Score);
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<UnityEngine.UI.Text>().text = "High Score: " + Score;
        //update saved highscore
        if(Score > PlayerPrefs.GetInt("ApplePickerHighScore")){
            PlayerPrefs.SetInt("ApplePickerHighScore", Score);
        }
    }
}
