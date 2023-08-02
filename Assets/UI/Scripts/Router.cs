using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Router : MonoBehaviour
{
    public Image root;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // 执行相应的操作
            if (SceneManager.GetActiveScene().name == "ChooseScene")
            {
                Application.Quit();
            }
            else
            {
                this.OpenBox();
            }
        }
    }

    public void push(string _route)
    {
        SceneManager.LoadScene(_route);
    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Play()
    {
        Time.timeScale = 1;
        root.gameObject.SetActive(false);
    }

    public void OpenBox()
    {
        root.gameObject.SetActive(true);
    }
}
