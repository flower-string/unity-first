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
        know.SetTitle("通信技术之WLAN技术");
        know.SetContent("通信技术之WLAN技术-物联网通信技术也在不断演进，过去主要基于WLAN技术，WLAN传输方便，适用于局域网范围内的设备连接，例如摄像头、门窗传感器、智能灯，都是只能连接Wi-Fi，通过Wi-Fi进行控制。");
    }
}
