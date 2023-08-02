using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject note;
    public Text title;
    public Text content;

    public void CloseNote()
    {
        note.SetActive(false);
    }

    public void ShowNote()
    {
        note.SetActive(true);
        Article a = ArticleManager.GetRandomArticle();
        this.SetTitle(a.title);
        SetContent(a.content);
    }

    public void SetTitle(string _title)
    {
        title.text = _title;
    }

    public void SetContent(string _content)
    {
        content.text = _content;
    }
}
