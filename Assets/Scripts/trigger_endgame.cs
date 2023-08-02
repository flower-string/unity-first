using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_endgame : MonoBehaviour
{
    public NpcManager end1;
    public string[] choose;
    public Router qz;
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
        qz.Pause();
        string[] choose = { "通讯设备", "传感设备", "交通设备", "信息设备" };
        end1.SetAnswer("B");
        end1.SetQuestion("物联网是通过________，按约定的协议把任何物品与互联网相连接，进行信息交换和通信，以实现对物品的智能化识别、定位、跟踪、监控和管理的一种网络。");
        end1.SetButton(choose);
        end1.ShowBox();
    }
}
