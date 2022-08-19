
using UnityEngine;

public class PlayeCollision : MonoBehaviour
{

    public NewMove movement;
 
     void OnCollisionEnter(Collision collectionInfo)
    {
        if(collectionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We Hit an Obstacle");
            movement.enabled = false;
        }
    }


        
    


}
