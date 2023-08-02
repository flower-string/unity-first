using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NpcManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text question;
    public Image[] btns;
    public Image box;
    public Image checks;
    private string _answer;
    private bool seted = false;
    public TipsManager tm;
    public void SetQuestion(string message)
    {
        if (!seted)
        {
            Debug.Log("请先设置答案");
            return;
        }
        question.text = message;
    }

    public void SetButton(string[] messages)
    {
        if (messages.Length == 0)
        {
            Debug.Log("选项问题");
            return;
        }
        if (!seted)
        {
            Debug.Log("请先设置答案");
            return;
        }
        checks.gameObject.SetActive(true);
        for (int i = 0; i < messages.Length; i++)
        {
            btns[i].gameObject.SetActive(true);
            Text txt = btns[i].GetComponentsInChildren<Text>()[0];
            txt.text = messages[i];
        }
    }

    public void ShowBox()
    {
        box.gameObject.SetActive(true);
    }

    public void HideBox()
    {
        checks.gameObject.SetActive(false);
        box.gameObject.SetActive(false);
    }

    public void SetAnswer(string right)
    {
        this._answer = right;
        this.seted = true;
    }

    public void CheckAnswer(string check)
    {
        if (check == this._answer)
        {
            this.HideBox();
            tm.ShowTips();
            tm.SetTips("恭喜回答正确！！");
        }
        else
        {
            this.HideBox();
            GameObject.Find("UIManager").GetComponent<ResultManager>().Fail();
        }

        this.seted = false;
    }
}
