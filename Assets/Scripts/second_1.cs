using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class second_1 : MonoBehaviour
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
    public void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        know.ShowNote();
        know.SetTitle("������");
        know.SetContent("������-�����������̽ṹ�У� ��֪�����������������������������ݻ�ȡ���⣬�ɸ��ִ������Լ����������ع��ɡ��ò㱻��Ϊ���������ĺ��Ĳ㣬��Ҫ����Ʒ��ʶ����Ϣ�����ܲɼ�");
    }
}
