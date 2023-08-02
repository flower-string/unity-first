using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class third_3 : MonoBehaviour
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
        know.SetTitle("通信技术之LPWAN技术");
        know.SetContent("通信技术之LPWAN技术-随着NB-IoT、eMTC和Lora为代表的LPWAN（低功耗广域网）的无线通信解决技术的崛起，也逐步地解决了物联网所遇到的网络应用问题。LPWAN技术使物联网设备之间的通信距离可以达到3至20公里，让数据可以进行长距离传输。");
    }
}
