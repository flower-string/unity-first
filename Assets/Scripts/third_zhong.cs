using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class third_zhong : MonoBehaviour
{
    int i = 0;
    public NpcManager ti;
    public ResultManager perfect;
    public string[] qz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void third_button()
    {
        if (i == 3)
        {
            perfect.Success();
        }
        if (i == 2)
        {
            string[] qz = { "全部", "网络", "广域网", "局域网" };
            ti.SetAnswer("D");
            ti.SetQuestion("物联网通信技术也在不断演进，主要基于WLAN技术，WLAN传输方便，适用于______范围内的设备连接，例如摄像头、门窗传感器,连接Wi-Fi，通过Wi-Fi控制。");
            ti.SetButton(qz);
            ti.ShowBox();
            i = 3;
        }
        if (i == 1)
        {
            string[] qz = { "LPWAN", "LPVAM", "LPNAM", "LPMAN" };
            ti.SetAnswer("A");
            ti.SetQuestion("低功耗广域网的英文简称为：");
            ti.SetButton(qz);
            ti.ShowBox();
            i = 2;
        }
        if (i == 0)
        {
            i = 1;
        }
    }
}
