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
            string[] qz = { "ȫ��", "����", "������", "������" };
            ti.SetAnswer("D");
            ti.SetQuestion("������ͨ�ż���Ҳ�ڲ����ݽ�����Ҫ����WLAN������WLAN���䷽�㣬������______��Χ�ڵ��豸���ӣ���������ͷ���Ŵ�������,����Wi-Fi��ͨ��Wi-Fi���ơ�");
            ti.SetButton(qz);
            ti.ShowBox();
            i = 3;
        }
        if (i == 1)
        {
            string[] qz = { "LPWAN", "LPVAM", "LPNAM", "LPMAN" };
            ti.SetAnswer("A");
            ti.SetQuestion("�͹��Ĺ�������Ӣ�ļ��Ϊ��");
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
