using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTriger : MonoBehaviour
{
    public Game_manager gameManager;



    void OnTriggerEnter() {

        gameManager.CompleteLevel();

    
   }
}
