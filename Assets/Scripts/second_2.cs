using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class second_2 : MonoBehaviour
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
        know.SetTitle("���������");
        know.SetContent("���������Ǹ�֪���ȡ��Ϣ�ĺ����������ν�����������ǰ���Ȼ���еĸ�������������ѧ����������ת��Ϊ�ɲ����ĵ��źŵ�װ����Ԫ����������һ��������Ԫ����ת��Ԫ�����任��·�͸�����Դ�Ĳ�����ɡ�");
    }
}
