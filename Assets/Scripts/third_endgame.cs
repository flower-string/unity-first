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
        string[] qz = { "��֪��", "Ӧ�ò�", "�����", "��Ϣ��" };
        end.SetAnswer("C");
        end.ShowBox();
        end.SetQuestion("�������������У�______�൱���˵�������ϵͳ�����𽫸�֪���ȡ����Ϣ����ȫ�ɿ��ش��䵽Ӧ�ò㣬Ȼ����ݲ�ͬ��Ӧ�����������Ϣ����");
        end.SetButton(qz);
    }
}
