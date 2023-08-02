using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class second_zhong : MonoBehaviour
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
    public void second_button()
    {
        if(i == 3)
        {
            perfect.Success();
        }
        if(i == 2)
        {
            string[] qz = { "网络层", "感知层", "应用层", "处理层" };
            ti.SetAnswer("B");
            ti.SetQuestion("传感器-在物联网工程结构中， ______解决的是人类世界和物理世界的数据获取问题，由各种传感器以及传感器网关构成。");
            ti.SetButton(qz);
            ti.ShowBox();
            i = 3;
        }
        if(i == 1)
        {
            string[] qz = {"传感器", "通讯器","应用器","处理器"};
            ti.SetAnswer("A");
            ti.SetQuestion("______是感知层获取信息的核心组件。______一般由敏感元件、转换元件、变换电路和辅助电源四部分组成。");
            ti.SetButton(qz);
            ti.ShowBox();
            i = 2;
        }
        if(i == 0)
        {
            i = 1;
        }
    }
}
