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
            string[] qz = { "�����", "��֪��", "Ӧ�ò�", "�����" };
            ti.SetAnswer("B");
            ti.SetQuestion("������-�����������̽ṹ�У� ______����������������������������ݻ�ȡ���⣬�ɸ��ִ������Լ����������ع��ɡ�");
            ti.SetButton(qz);
            ti.ShowBox();
            i = 3;
        }
        if(i == 1)
        {
            string[] qz = {"������", "ͨѶ��","Ӧ����","������"};
            ti.SetAnswer("A");
            ti.SetQuestion("______�Ǹ�֪���ȡ��Ϣ�ĺ��������______һ��������Ԫ����ת��Ԫ�����任��·�͸�����Դ�Ĳ�����ɡ�");
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
