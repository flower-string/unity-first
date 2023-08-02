using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class third_endgame : MonoBehaviour
{
    public NpcManager end;
    public string[] qz;
    public Router zan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        zan.Pause();
        string[] qz = { "感知层", "应用层", "网络层", "信息层" };
        end.SetAnswer("C");
        end.ShowBox();
        end.SetQuestion("在物联网工程中，______相当于人的神经中枢系统，负责将感知层获取的信息，安全可靠地传输到应用层，然后根据不同的应用需求进行信息处理。");
        end.SetButton(qz);
    }
}
