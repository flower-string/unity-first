using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class TipsManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject box;
    public Text tip;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowTips()
    {
        box.SetActive(true);
    }

    public void SetTips(string message)
    {
        tip.text = message;
    }

    public void CloseTips()
    {
        box.SetActive(false);
    }
}
