using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class second_3 : MonoBehaviour
{
    public NoteManager know;
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
        gameObject.SetActive(false);
        know.ShowNote();
        know.SetTitle("΢����ϵͳ����");
        know.SetContent("�ڴ������MEMS������΢����ϵͳ������������΢�͡��ͳɱ����͹��Ĵ������ڵ�Ĺؼ�������MEMS���������ŵ㣬���������С�������ᡢ���ĵ͡������Ժá��۸�����������ȶ��ȡ�");

    }
}
