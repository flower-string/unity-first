using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Canera_following : MonoBehaviour
{
    private Transform player;
    private Vector3 Offsetposition;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
        Offsetposition = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + Offsetposition;
    }
}
