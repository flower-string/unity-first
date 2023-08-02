using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//场景
public class HelloScript : MonoBehaviour
{
    public Text message;

    void Start()
    {
        // 根据设备类型显示不同的提示
        if (Application.platform == RuntimePlatform.Android ||
            Application.platform == RuntimePlatform.IPhonePlayer)
        {
            message.text = "Touch To Start";
        }
        else
        {
            message.text = "按 任 意 键 开 始";
        }
    }

    void Update()
    {
        // 监听用户的点击和按键
        if (Input.GetMouseButtonDown(0) || Input.anyKey)
        {
            // 用户开始游戏，执行相应的逻辑
            StartGame();
        }
    }

    void StartGame()
    {
        // 在这里执行游戏开始的逻辑
        SceneManager.LoadScene("ChooseScene");
    }
    
    
}
