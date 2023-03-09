using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject player;
    public GameObject characterModel;

    void OnTriggerEnter(Collider other)
    {
        // Prevent collision from triggering infinitely
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        
        // Make player stop and fall over
        player.GetComponent<PlayerMove>().enabled = false;
        characterModel.GetComponent<Animator>().Play("Stumble Backwards");
    }
}
