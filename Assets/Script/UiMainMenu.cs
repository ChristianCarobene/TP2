using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiMainMenu : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button creditsButton;
    [SerializeField] private Button historyButton;
    [SerializeField] private Button exitButton;

    [SerializeField] private GameObject canvasPanel;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject pauseImage;
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject creditsPanel;
    [SerializeField] private GameObject historyPanel;
    [SerializeField] private Movement player1;
    [SerializeField] private Movement player2;
    [SerializeField] private Play_Ball ball;


    private void Awake()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);
        settingsButton.onClick.AddListener(OnSettingsButtonClicked);
        creditsButton.onClick.AddListener(OnCreditsButtonClicked);
        historyButton.onClick.AddListener(OnHistoryButtonClicked);
        exitButton.onClick.AddListener(OnExitButtonClicked);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausePanel.SetActive(!pausePanel.activeSelf);
            pauseImage.SetActive(!pauseImage.activeSelf);
            canvasPanel.SetActive(!canvasPanel.activeSelf);
            player1.isPause = !player1.isPause;
            player2.isPause = !player2.isPause;
            ball.isPause = !ball.isPause;

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
        pausePanel.SetActive(!pausePanel.activeSelf);
        pauseImage.SetActive(!pauseImage.activeSelf);
        canvasPanel.SetActive(!canvasPanel.activeSelf);
        player1.isPause = false;
        player2.isPause = false;
        ball.isPause = false;
        ball.KickOff();
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
    private void OnHistoryButtonClicked()
    {
        historyPanel.SetActive(true);
        pausePanel.SetActive(false);
        Debug.Log("OnHistoryButtonClicked");

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

