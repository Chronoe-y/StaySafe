using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMenu : MonoBehaviour
{
    [SerializeField] GameObject volumePanel;

    // ���������ťʱ����
    public void ShowVolumePanel()
    {
        volumePanel.SetActive(true);
    }

    // ��� �� ��ťʱ����
    public void HideVolumePanel()
    {
        volumePanel.SetActive(false);
    }
}
