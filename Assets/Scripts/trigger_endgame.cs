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
        string[] choose = { "ͨѶ�豸", "�����豸", "��ͨ�豸", "��Ϣ�豸" };
        end1.SetAnswer("B");
        end1.SetQuestion("��������ͨ��________����Լ����Э����κ���Ʒ�뻥���������ӣ�������Ϣ������ͨ�ţ���ʵ�ֶ���Ʒ�����ܻ�ʶ�𡢶�λ�����١���غ͹����һ�����硣");
        end1.SetButton(choose);
        end1.ShowBox();
    }
}
