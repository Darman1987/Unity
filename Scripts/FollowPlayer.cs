using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;  // varible save reference of vehicle  attaching vehicle to this variable.
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate is called after Update method
    void LateUpdate()
    {                                                    //offset the camer behind the player's position
        transform.position = player.transform.position + offset;
    }
}
