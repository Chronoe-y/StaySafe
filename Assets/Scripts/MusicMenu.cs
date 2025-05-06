using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMenu : MonoBehaviour
{
    [SerializeField] GameObject volumePanel;

    // 点击音量按钮时调用
    public void ShowVolumePanel()
    {
        volumePanel.SetActive(true);
    }

    // 点击 × 按钮时调用
    public void HideVolumePanel()
    {
        volumePanel.SetActive(false);
    }
}
