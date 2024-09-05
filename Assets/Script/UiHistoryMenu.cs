using UnityEngine;
using UnityEngine.UI;

public class UiHistoryMenu : MonoBehaviour
{
    [SerializeField] private Button backButton;
    [SerializeField] private GameObject referencePanel;
    [SerializeField] private GameObject pausePanel;
    void Awake()
    {
        backButton.onClick.AddListener(OnBackButtonClicked);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            referencePanel.SetActive(!referencePanel.activeSelf);

        }
    }
    private void OnBackButtonClicked()
    {
        referencePanel.SetActive(false);
        pausePanel.SetActive(true);
        Debug.Log("OnBackButtonClicked");
    }
}
