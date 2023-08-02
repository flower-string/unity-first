using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class knowledge_see : MonoBehaviour
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
        know.SetTitle("物联网");
        know.SetContent("物联网的英文名称是Internet of Things，简称为IOT，其核心和基础仍然是互联网，是在互联网基础上的延伸和扩展的网络。");
        gameObject.SetActive(false);
    }
}
