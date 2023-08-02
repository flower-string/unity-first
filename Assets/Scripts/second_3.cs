using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class second_3 : MonoBehaviour
{
    public NoteManager know;
    public Router zan;
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
        know.SetTitle("微机电系统技术");
        know.SetContent("在传感器里，MEMS技术（微机电系统技术）是制造微型、低成本、低功耗传感器节点的关键技术。MEMS传感器的优点，包括了体积小、重量轻、功耗低、耐用性好、价格低廉、性能稳定等。");

    }
}
