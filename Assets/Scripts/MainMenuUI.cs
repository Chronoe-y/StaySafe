using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    // �ڰ�ť���ʱ����
    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("Game Scene");
    }
}

