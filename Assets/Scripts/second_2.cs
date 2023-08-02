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
        know.SetTitle("传感器组成");
        know.SetContent("传感器便是感知层获取信息的核心组件。所谓传感器，就是把自然界中的各种物理量、化学量、生物量转化为可测量的电信号的装置与元件。传感器一般由敏感元件、转换元件、变换电路和辅助电源四部分组成。");
    }
}
