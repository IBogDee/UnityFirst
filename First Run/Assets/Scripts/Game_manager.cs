using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class Game_manager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartDelay = 1f;


    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        Debug.Log("Level1");
        completeLevelUI.SetActive(true);

    }


    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart",restartDelay);

            //restart the game 
        }
    }

    void Restart ()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name); < load the active scene
        //SceneManager.LoadScene("")  < load the name of the Scene 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
