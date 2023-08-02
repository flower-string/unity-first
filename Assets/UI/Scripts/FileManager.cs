using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FileManager : MonoBehaviour
{
    public GameObject mulu;
    public Text content;
    public GameObject root;
    public Button btn;

    public void showFile()
    {
        root.SetActive(true);
        RenderReadArticles();
    }

    void OnEnable()
    {

    }

    private void Start()
    {
        btn = Resources.Load<Button>("Mulu");
    }

    public void closeFile()
    {
        root.SetActive(false);
    }

    public void SwitchContent(string _article)
    {
        content.text = _article;
    }

    private void RenderReadArticles()
    {
        List<Article> readArticles = ArticleManager.articles;

        foreach (Article article in readArticles)
        {
            Debug.Log(article);
            Button newButton = Instantiate(btn, mulu.transform);
            newButton.GetComponentInChildren<Text>().text = article.title;
            // newButton.onClick.AddListener(() => SwitchContent(article.content));
        }
    }
}