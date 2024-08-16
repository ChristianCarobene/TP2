using UnityEngine;
using UnityEngine.UI;

public class UiCreditsMenu : MonoBehaviour
{
    [SerializeField] private Button backButton;
    [SerializeField] private GameObject referencePanel;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private Movement player1;
    [SerializeField] private Movement player2;


    private void Awake()
    {
        backButton.onClick.AddListener(OnBackButtonClicked);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            referencePanel.SetActive(!referencePanel.activeSelf);

        }
    }

    private void OnDestroy()
    {
        backButton.onClick.RemoveAllListeners();
    }


    private void OnBackButtonClicked()
    {
        referencePanel.SetActive(false);
        pausePanel.SetActive(true);
        Debug.Log("OnBackButtonClicked");
    }
}
