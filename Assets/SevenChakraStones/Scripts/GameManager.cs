using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    IntroScreen introScreen;
    ChakraQuiz quiz;
    EndScreen endScreen;
    

    

    void Awake()
    {
        introScreen = GetComponent<IntroScreen>();
        quiz = FindObjectOfType<ChakraQuiz>();
        endScreen = FindObjectOfType<EndScreen>();
    }

    void Start()
    {
        //introScreen.gameObject.SetActive(true);
        quiz.gameObject.SetActive(true);   
        endScreen.gameObject.SetActive(false);
    }

    void Update()
    {
        if (quiz.isComplete)
        {
            introScreen.gameObject.SetActive(false);
            quiz.gameObject.SetActive(false);
            endScreen.gameObject.SetActive(true);
            endScreen.ShowFinalScore();
        }
    }

    public void OnStartLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void OnReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void StartLevelOne()
    {
        Debug.Log("we made it this far");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
