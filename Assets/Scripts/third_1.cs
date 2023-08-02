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
        know.SetTitle("通信技术");
        know.SetContent("通信技术-在物联网工程中，网络层相当于人的神经中枢系统，负责将感知层获取的信息，安全可靠地传输到应用层，然后根据不同的应用需求进行信息处理。");
    }
}
