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
        know.SetTitle("������");
        know.SetContent("��������Ӣ��������Internet of Things�����ΪIOT������ĺͻ�����Ȼ�ǻ����������ڻ����������ϵ��������չ�����硣");
        gameObject.SetActive(false);
    }
}
