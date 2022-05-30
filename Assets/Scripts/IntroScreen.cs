using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class IntroScreen : MonoBehaviour
{
    //[SerializeField] TextMeshProUGUI finalScoreText;
   // ScoreKeeper scoreKeeper;

    void Awake()
    {
        //scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    public void StartLevelOne()
    {
        Debug.Log("we made it this far");
        SceneManager.LoadScene(1);
    }
}


//[SerializeField] UnityEngine.Object startButton;
    //[SerializeField] float levelLoadDelay = 2f;
    //[SerializeField] GameObject startButton;
    //public Button startButton;

//startButton.onClick.AddListener(TaskOnClick);

//public void TaskOnClick()
    //{
   //     SceneManager.LoadScene(1);
    //    Debug.Log("You have clicked the button");
    //}

//public void StartGame()
   // {
  //      SceneManager.LoadScene(1);
   // }

   // public void ContinueGame(bool state)
   // {
   //     SceneManager.LoadScene(1);
   //     //startButton.SetActive(state);
   //     Invoke("LoadNextLevel", levelLoadDelay);
    //}

   // void SetButtonState(bool state)
   // {
        
       // Button button = startButtons.GetComponent<Button>();
       // button.interactable = state;
   // }
