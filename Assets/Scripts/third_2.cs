using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class third_2 : MonoBehaviour
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
        know.SetTitle("ͨ�ż���֮WLAN����");
        know.SetContent("ͨ�ż���֮WLAN����-������ͨ�ż���Ҳ�ڲ����ݽ�����ȥ��Ҫ����WLAN������WLAN���䷽�㣬�����ھ�������Χ�ڵ��豸���ӣ���������ͷ���Ŵ������������ܵƣ�����ֻ������Wi-Fi��ͨ��Wi-Fi���п��ơ�");
    }
}
