using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frist_zhong : MonoBehaviour
{
    public NpcManager end1;
    public ResultManager hoory;
    public string[] choose;
    public int i=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showsecond_question()
    {
        if (i == 1)
        {
            hoory.Success();
        }
        else if (i==0)
        {
            i = 2;
        }
        else
        {
            string[] choose = { "感知层,网络层,应用层", "网络层,感知层,应用层", "感知层,应用层,网络层", "应用层,感知层,网络层" };
            end1.SetAnswer("A");
            end1.SetQuestion("通常，一个物联网工程大体上分成了三个部分。第一个部分：传感设备部分（____）,第二部分：通信技术部分（____），最后一部分：智能处理部分（____）.");
            end1.SetButton(choose);
            end1.ShowBox();
            i = 1;
        }
    }
}
