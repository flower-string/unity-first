using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class second_endgame : MonoBehaviour
{
    public NpcManager end;
    public string[] qz;
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
        zan.Pause();
        string[] qz = { "SMNM","MSNN","NMMS","MEMS" };
        end.SetAnswer("D");
        end.ShowBox();
        end.SetQuestion("΢����ϵͳ������Ӣ�ļ���ǣ�");
        end.SetButton(qz);
    }
}
