using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class first_2 : MonoBehaviour
{
    public NoteManager know;
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
        know.ShowNote();
        know.SetTitle("���������̵����󲿷�");
        know.SetContent("ͨ����һ�����������̴����Ϸֳ����������֡���һ�����֣������豸���֣���֪�㣩��Ҳ����������Ƶʶ�𡢶�ά�롢�������ȴ����豸����֪�ͻ�ȡ����ĸ�����Ϣ���ڶ����֣�ͨ�ż������֣�����㣩����ͨ���Ի�����������������ںϣ����������Ϣʵʱ��׼ȷ�ش��ͣ��Ա���Ϣ�������������һ���֣����ܴ����֣�Ӧ�ò㣩����ʹ�ø������ܼ������Ը�֪�ʹ��͵������ݡ���Ϣ���з�������ʵ�ּ������Ƶ����ܻ�����ˣ���������������Ϣ���Ĺ����оͱ���߱�������������һ���ǻ�ȡ��Ϣ��������һ�����Ǵ�����Ϣ�����������һ�����Ǵ�����Ϣ��������");
        gameObject.SetActive(false);
    }
}
