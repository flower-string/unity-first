using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quit_zhu : MonoBehaviour
{
    public Router qz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void quit_zhuye()
    {
        qz.Play();
        SceneManager.LoadScene("ChooseScene");
    }
}
