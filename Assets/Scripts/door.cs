using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    private GameObject[] know;
    public NoteManager tip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        know = GameObject.FindGameObjectsWithTag("knowledge");
        if(know.Length == 0)
        {
            gameObject.SetActive(false);
        }
        else
        {
            tip.ShowNote();
            tip.SetTitle("����֪ʶ��û���ռ����Ŷ��");
            tip.SetContent("������ռ�ʣ���֪ʶ�㡣tips:ʰȡ���������ڸ��õ��ռ�֪ʶ��Ŷ�����ҿ��Թ۲����Ͻ�С��ͼ���鿴֪ʶ��λ�á�");
        }
    }
}
