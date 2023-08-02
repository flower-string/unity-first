using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResultManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text level;
    public Text result;
    public Text question;
    public Image quit;
    public Image next;
    public GameObject root;

    public void Success()
    {
        this.root.SetActive(true);
        this.quit.gameObject.SetActive(true);
        this.next.gameObject.SetActive(true);
        this.result.text = "Prefect";
        string title = ArticleManager.GetRandomArticle().title;
        this.question.text = title;
    }

    public void Fail()
    {
        this.root.SetActive(true);
        this.quit.gameObject.SetActive(true);
        this.result.text = "False";
        string title = ArticleManager.GetRandomArticle().title;
        this.question.text = title;
    }

    public void CloseBox()
    {
        this.root.SetActive(false);
        this.next.gameObject.SetActive(false);
        this.quit.gameObject.SetActive(false);
    }

    public void SetTitle(string _title)
    {
        this.level.text = _title;
    }
}
