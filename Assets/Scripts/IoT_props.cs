using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IoT_ : MonoBehaviour
{
    public GameObject[] hide_kill;
    public GameObject[] IOT;
    public GameObject[] knowledge;
    public NpcManager npc;
    public string[] answer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        string[] answer = { "IT", "OTL", "IOT", "LTO" };
        npc.SetAnswer("C");
        npc.SetQuestion("物联网的英文简称是:");
        npc.SetButton(answer);
        npc.ShowBox();
        hide_kill = GameObject.FindGameObjectsWithTag("hide_killer");
        for(int i = 0; i < hide_kill.Length; i++)
        {
            hide_kill[i].GetComponent<MeshRenderer>().enabled = true;
        }
        IOT = GameObject.FindGameObjectsWithTag("IOT");
        for(int j = 0; j < IOT.Length; j++)
        {
            IOT[j].SetActive(false);
        }
        knowledge = GameObject.FindGameObjectsWithTag("knowledge");
        for( int k = 0; k < knowledge.Length; k++)
        {
            knowledge[k].GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
