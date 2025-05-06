using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic instance;
    private AudioSource audioSource;

    void Awake()
    {
        // 单例逻辑：保留第一个实例，后来的都销毁
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            audioSource = GetComponent<AudioSource>();
            // 订阅场景加载事件
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void OnDestroy()
    {
        // 注销订阅，避免内存泄漏
        if (instance == this)
            SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // 当任意场景加载完成后被调用
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // 假设“Game”是你的游戏主场景名；改成你实际的场景名
        if (scene.name == "Game Scenes")
        {
            // 停止原有音乐，并从头播放
            if (audioSource.isPlaying)
                audioSource.Stop();
            audioSource.Play();
        }
    }
}

