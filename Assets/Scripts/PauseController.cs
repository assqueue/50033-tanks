using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class PauseController : MonoBehaviour {

     public static bool GameIsPaused = false;
     public GameObject pauseUI;

     void Update () {
            if (Input.GetKeyDown(KeyCode.Escape)){
                if (GameIsPaused)
                {
                    Resume();
                }
                else{
                    Pause();
                }
            }
         }
    void Resume(){
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause(){
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
 }    