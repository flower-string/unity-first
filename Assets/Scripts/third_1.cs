using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class third_1 : MonoBehaviour
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
        know.SetTitle("ͨ�ż���");
        know.SetContent("ͨ�ż���-�������������У�������൱���˵�������ϵͳ�����𽫸�֪���ȡ����Ϣ����ȫ�ɿ��ش��䵽Ӧ�ò㣬Ȼ����ݲ�ͬ��Ӧ�����������Ϣ����");
    }
}
