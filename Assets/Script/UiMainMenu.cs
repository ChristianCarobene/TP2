using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiMainMenu : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button creditsButton;
    [SerializeField] private Button exitButton;

    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject creditsPanel;
    [SerializeField] private Movement player1;
    [SerializeField] private Movement player2;


    private void Awake()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);
        settingsButton.onClick.AddListener(OnSettingsButtonClicked);
        creditsButton.onClick.AddListener(OnCreditsButtonClicked);
        exitButton.onClick.AddListener(OnExitButtonClicked);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausePanel.SetActive(!pausePanel.activeSelf);
            player1.isPause = !player1.isPause;
            player2.isPause = !player2.isPause;
        }
    }


    private void OnDestroy()
    {
        playButton.onClick.RemoveAllListeners();
        settingsButton.onClick.RemoveAllListeners();
        creditsButton.onClick.RemoveAllListeners();
        exitButton.onClick.RemoveAllListeners();
    }


    private void OnPlayButtonClicked()
    {
        pausePanel.SetActive(false);
        player1.isPause = false;
        player2.isPause = false;
        Debug.Log("OnPlayButtonClicked");
    }
    private void OnSettingsButtonClicked()
    {
        settingsPanel.SetActive(true);
        pausePanel.SetActive(false);
        Debug.Log("OnSettingsButtonClicked");
    }
    private void OnCreditsButtonClicked()
    {
        creditsPanel.SetActive(true);
        pausePanel.SetActive(false);
        Debug.Log("OnCreditsButtonClicked");

    }
    private void OnExitButtonClicked()
    {
       
        Debug.Log("OnExitButtonClicked");
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}

