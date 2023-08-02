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
        know.SetTitle("传感器");
        know.SetContent("传感器-在物联网工程结构中， 感知层解决的是人类世界和物理世界的数据获取问题，由各种传感器以及传感器网关构成。该层被认为是物联网的核心层，主要是物品标识和信息的智能采集");
    }
}
