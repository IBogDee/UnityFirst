
using UnityEngine;

public class PlayeCollision : MonoBehaviour
{

    public NewMove movement;
    public Game_manager gameManger;

     void OnCollisionEnter(Collision collectionInfo)
    {
        if(collectionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We Hit an Obstacle");
            movement.enabled = false;
        }
    }


        
    


}
