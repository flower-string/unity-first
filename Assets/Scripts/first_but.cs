using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class first_but : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void first_button()
    {
        SceneManager.LoadScene("level_first");
    }
    public void second_button()
    {
        SceneManager.LoadScene("level_second");
    }
    public void third_button()
    {
        SceneManager.LoadScene("level_third");
    }
}
