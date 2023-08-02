using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArticleManager : MonoBehaviour
{
    public TextAsset textAsset;
    public static List<Article> articles = new List<Article>();
    public static List<Article> readArticles = new List<Article>();
    public static List<Article> unreadArticles = new List<Article>();
    // Start is called before the first frame update
    void Start()
    {
        if (textAsset != null)
        {
            string[] lines = textAsset.text.Split('\n');
            foreach (string line in lines)
            {
                Debug.Log(lines);
                string[] parts = line.Split('-');
                if (parts.Length == 2)
                {
                    Article article = new Article(parts[0], parts[1]);
                    articles.Add(article);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static Article GetRandomArticle()
    {
        if (articles.Count == 0)
        {
            return null;
        }
        int randomIndex = Random.Range(0, articles.Count);
        return articles[randomIndex];
    }
    
    public static Article GetRandomReadArticle()
    {
        if (readArticles.Count == 0)
        {
            return null;
        }
        int randomIndex = Random.Range(0, readArticles.Count);
        return readArticles[randomIndex];
    }

    public static Article GetRandomUnreadArticle()
    {
        if (unreadArticles.Count == 0)
        {
            return null;
        }
        int randomIndex = Random.Range(0, unreadArticles.Count);
        Article article = unreadArticles[randomIndex];
        unreadArticles.RemoveAt(randomIndex);
        readArticles.Add(article);
        return article;
    }

}

public class Article 
{
    public string title;
    public string content;
    void Start()
    {
        
    }
    
    public Article(string _title, string _content)
    {
        this.title = _title;
        this.content = _content;
    }
}