using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StonePickup : MonoBehaviour
{
        //GameBackGround gameBackGround;
        //BasicBehaviour basicBehaviour;
        //ThirdPersonOrbitCamBasic thirdPersonOrbitCamBasic;
        //ChakraQuiz quiz;

        void Start()
        {
            //quiz.gameObject.SetActive(false);
            //gameBackGround.gameObject.SetActive(false);
            //basicBehaviour.gameObject.SetActive(true);
            //thirdPersonOrbitCamBasic.gameObject.SetActive(true);
        }


        private void Awake()
        {
            //quiz = FindObjectOfType<ChakraQuiz>();
            //gameBackGround = FindObjectOfType<GameBackGround>();
            //basicBehaviour = FindObjectOfType<BasicBehaviour>();
            //thirdPersonOrbitCamBasic = FindObjectOfType<ThirdPersonOrbitCamBasic>();    
        }
        void Update()
        {

        }

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "FieldCollider" || other.tag == "Player")
            {
                return;
            }

            if (other.gameObject.CompareTag("StonePickup"))
            {
                other.gameObject.GetComponent<Renderer>().enabled = true;
                Debug.Log("mad it this far");
                LoadNextLevel();
                



                //basicBehaviour.gameObject.SetActive(false);
                //thirdPersonOrbitCamBasic.gameObject.SetActive(false);
                //gameBackGround.gameObject.SetActive(true);
                //quiz.gameObject.SetActive(true);
            }
        }
    void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }

}


