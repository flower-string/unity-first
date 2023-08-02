using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goback_button : MonoBehaviour
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
    public void goback_scene()
    {
        qz.Pause();
        qz.OpenBox();
    }
}
