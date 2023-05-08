using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseResume : MonoBehaviour
{
    bool isPause = false;
    public GameObject PasueMenuUi;
    void Update()
    {
        if (Input.GetKeyDown("escape")) {
             
             if(isPause == true)
             { 
                 ResumeGame();
             } 
             
             else {
                 PauseGame();
             }
         }
     }
    
    public void PauseGame() 
    {
        Time.timeScale = 0.0f;
        isPause = true;
        PasueMenuUi.SetActive(true);
    }
    public void ResumeGame() 
    {
        Time.timeScale = 1.0f;
        isPause = false;
        PasueMenuUi.SetActive(false);
    }

    public void LoadMenu() {
         
         SceneManager.LoadScene("Menu");
         isPause = false;
         Time.timeScale = 1.0f;


    }
}
