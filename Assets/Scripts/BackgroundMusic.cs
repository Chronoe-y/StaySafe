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
        // �����߼���������һ��ʵ���������Ķ�����
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            audioSource = GetComponent<AudioSource>();
            // ���ĳ��������¼�
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void OnDestroy()
    {
        // ע�����ģ������ڴ�й©
        if (instance == this)
            SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // �����ⳡ��������ɺ󱻵���
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // ���衰Game���������Ϸ�����������ĳ���ʵ�ʵĳ�����
        if (scene.name == "Game Scenes")
        {
            // ֹͣԭ�����֣�����ͷ����
            if (audioSource.isPlaying)
                audioSource.Stop();
            audioSource.Play();
        }
    }
}

