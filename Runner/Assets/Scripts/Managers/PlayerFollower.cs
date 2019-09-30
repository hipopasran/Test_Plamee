﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour {

    public Transform player;

    private Vector3 offset;
        
    void Start()
    {
        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        transform.position = new Vector3(player.position.x + offset.x,this.transform.position.y,this.transform.position.z);
    }
}
