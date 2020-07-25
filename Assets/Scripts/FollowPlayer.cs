using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//armeen
public class FollowPlayer : MonoBehaviour
{
    //creates a player object which is connected to the camera. In unity. dragged the vehicle to the player object which connects them
    public GameObject player;
    private Vector3 offset = new Vector3(0, 8, -15);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //assign cameras position to the vehicles position
        //offset the camera behind the player by adding to the players position
        transform.position = player.transform.position + offset;


    }
}
