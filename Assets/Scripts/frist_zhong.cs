using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frist_zhong : MonoBehaviour
{
    public NpcManager end1;
    public ResultManager hoory;
    public string[] choose;
    public int i=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showsecond_question()
    {
        if (i == 1)
        {
            hoory.Success();
        }
        else if (i==0)
        {
            i = 2;
        }
        else
        {
            string[] choose = { "��֪��,�����,Ӧ�ò�", "�����,��֪��,Ӧ�ò�", "��֪��,Ӧ�ò�,�����", "Ӧ�ò�,��֪��,�����" };
            end1.SetAnswer("A");
            end1.SetQuestion("ͨ����һ�����������̴����Ϸֳ����������֡���һ�����֣������豸���֣�____��,�ڶ����֣�ͨ�ż������֣�____�������һ���֣����ܴ����֣�____��.");
            end1.SetButton(choose);
            end1.ShowBox();
            i = 1;
        }
    }
}
