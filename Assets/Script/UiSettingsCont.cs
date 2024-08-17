using UnityEngine;
using UnityEngine.UI;

public class UiSettingsCont : MonoBehaviour
{
    [SerializeField] private Button backButton;
    [SerializeField] private GameObject referencePanel;
    [SerializeField] private GameObject subReferencePanel;
    [SerializeField] private GameObject settingsPanel;
 
    private void Awake()
    {
        backButton.onClick.AddListener(OnBackButtonClicked);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            referencePanel.SetActive(!referencePanel.activeSelf);
            subReferencePanel.SetActive(!subReferencePanel.activeSelf);

        }
    }

    private void OnDestroy()
    {
        backButton.onClick.RemoveAllListeners();
            }


    private void OnBackButtonClicked()
    {
        referencePanel.SetActive(false);
        subReferencePanel.SetActive(false);
        settingsPanel.SetActive(true);

        Debug.Log("OncloseButtonClicked");
    }


}
