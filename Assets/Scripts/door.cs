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
            tip.SetTitle("还有知识点没有收集完毕哦！");
            tip.SetContent("请继续收集剩余的知识点。tips:拾取道具有助于更好的收集知识点哦！并且可以观察左上角小地图来查看知识点位置。");
        }
    }
}
