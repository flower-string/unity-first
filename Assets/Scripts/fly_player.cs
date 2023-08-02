using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fly_player : MonoBehaviour
{
    public GameObject player;
    private Player_Controller playerController;
    int aa;
    // Start is called before the first frame update
    void Start()
    {
        aa = 7;
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<Player_Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        playerController.setspeed(aa);
        this.gameObject.SetActive(false);
        Debug.Log("ÌøÔ¾ÔöÇ¿");
    }
}
