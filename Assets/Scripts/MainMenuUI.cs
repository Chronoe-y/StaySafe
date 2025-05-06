using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    // 在按钮点击时调用
    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("Game Scene");
    }
}

