using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginPanel : MonoBehaviour
{
    public Button loginBtn;

    private void Awake()
    {
        loginBtn.onClick.AddListener(() =>
        {
            // 登录按钮被点击，进入Game场景
            SceneManager.LoadScene(1);
        });
    }
}
