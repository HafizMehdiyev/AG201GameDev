using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject PausePanel;
    [SerializeField] GameObject SettingsPanel;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PausePanel.transform.localScale = Vector3.zero;
            PausePanel.SetActive(true);
            var seq = DOTween.Sequence();
            seq.Append(PausePanel.transform.DOScale(1, .5f)).Insert(.4f, PausePanel.transform.DOShakeScale(1f, 1f, 3))
                .OnComplete(() =>
                {
                    Time.timeScale = 0.3f;
                });
        }
    }

    public void Resume()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
    }
    public void OpenSettingsPanel()
    {
        SettingsPanel.SetActive(true);
        PausePanel.SetActive(false);
    }

}
