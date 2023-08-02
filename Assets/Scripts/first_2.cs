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
        know.SetTitle("物联网工程的三大部分");
        know.SetContent("通常，一个物联网工程大体上分成了三个部分。第一个部分：传感设备部分（感知层），也就是利用射频识别、二维码、传感器等传感设备，感知和获取物体的各类信息；第二部分：通信技术部分（网络层），是通过对互联网、无线网络的融合，将物体的信息实时、准确地传送，以便信息交流、分享；最后一部分：智能处理部分（应用层），即使用各种智能技术，对感知和传送到的数据、信息进行分析处理，实现监测与控制的智能化。因此，物联网在整个信息流的过程中就必须具备有三种能力，一个是获取信息的能力，一个则是传送信息的能力，最后一个则是处理信息的能力。");
        gameObject.SetActive(false);
    }
}
