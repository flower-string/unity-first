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
        know.SetTitle("ͨ�ż���֮LPWAN����");
        know.SetContent("ͨ�ż���֮LPWAN����-����NB-IoT��eMTC��LoraΪ�����LPWAN���͹��Ĺ�������������ͨ�Ž������������Ҳ�𲽵ؽ����������������������Ӧ�����⡣LPWAN����ʹ�������豸֮���ͨ�ž�����Դﵽ3��20��������ݿ��Խ��г����봫�䡣");
    }
}
