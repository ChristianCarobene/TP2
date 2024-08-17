using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiSettingsMenu : MonoBehaviour
{
    [SerializeField] private Button backButton;
    [SerializeField] private Button close1Button;
    [SerializeField] private Button close2Button;
    [SerializeField] private Button controllerButton1;
    [SerializeField] private Button controllerButton2;
    [SerializeField] private GameObject referencePanel;
    [SerializeField] private GameObject controllerPanel;
    [SerializeField] private GameObject subController1Panel;
    [SerializeField] private GameObject subController2Panel;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private Slider towerSlide1;
    [SerializeField] private Slider bodySlide1;
    [SerializeField] private Slider canonSlide1;
    [SerializeField] private Slider trucksSlide1;
    [SerializeField] private Slider speedSlide1; 
    [SerializeField] private Slider towerSlide2;
    [SerializeField] private Slider bodySlide2;
    [SerializeField] private Slider canonSlide2;
    [SerializeField] private Slider trucksSlide2;
    [SerializeField] private Slider speedSlide2;
    [SerializeField] private TextMeshProUGUI towerTMP1;
    [SerializeField] private TextMeshProUGUI bodyTMP1;
    [SerializeField] private TextMeshProUGUI canonTMP1;
    [SerializeField] private TextMeshProUGUI trucksTMP1;
    [SerializeField] private TextMeshProUGUI speedTMP1;
    [SerializeField] private TextMeshProUGUI towerTMP2;
    [SerializeField] private TextMeshProUGUI bodyTMP2;
    [SerializeField] private TextMeshProUGUI canonTMP2;
    [SerializeField] private TextMeshProUGUI trucksTMP2;
    [SerializeField] private TextMeshProUGUI speedTMP2;
    [SerializeField] private Movement player1;
    [SerializeField] private Movement player2;
    [SerializeField] private UiTank tankUi1;
    [SerializeField] private UiTank tankUi2;



    private void Awake()
    {
        backButton.onClick.AddListener(OnBackButtonClicked);
        controllerButton1.onClick.AddListener(OnControllerButtonClicked1);
        controllerButton2.onClick.AddListener(OnControllerButtonClicked2);
        towerSlide1.onValueChanged.AddListener(OnSlide1Change);
        bodySlide1.onValueChanged.AddListener(OnSlide1Change);
        canonSlide1.onValueChanged.AddListener(OnSlide1Change);
        trucksSlide1.onValueChanged.AddListener(OnSlide1Change);
        speedSlide1.onValueChanged.AddListener(OnSlide1Change);
        towerSlide2.onValueChanged.AddListener(OnSlide1Change);
        bodySlide2.onValueChanged.AddListener(OnSlide1Change);
        canonSlide2.onValueChanged.AddListener(OnSlide1Change);
        trucksSlide2.onValueChanged.AddListener(OnSlide1Change);
        speedSlide2.onValueChanged.AddListener(OnSlide1Change);

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
        controllerButton1.onClick.RemoveAllListeners();
        controllerButton2.onClick.RemoveAllListeners();
        towerSlide1.onValueChanged.RemoveAllListeners();
        bodySlide1.onValueChanged.RemoveAllListeners();
        canonSlide1.onValueChanged.RemoveAllListeners();
        trucksSlide1.onValueChanged.RemoveAllListeners();
        speedSlide1.onValueChanged.RemoveAllListeners();
        towerSlide2.onValueChanged.RemoveAllListeners();
        bodySlide2.onValueChanged.RemoveAllListeners();
        canonSlide2.onValueChanged.RemoveAllListeners();
        trucksSlide2.onValueChanged.RemoveAllListeners();
        speedSlide2.onValueChanged.RemoveAllListeners();
    }


    private void OnBackButtonClicked()
    {
        referencePanel.SetActive(false);
        pausePanel.SetActive(true);

        Debug.Log("OnBackButtonClicked");
    }
    private void OnSlide1Change(float newValue)
    {
        player1.typeCanon = (int)canonSlide1.value;
        player1.typeBody = (int)bodySlide1.value;
        player1.typeTower = (int)towerSlide1.value;
        player1.typeTrucks = (int)trucksSlide1.value;
        canonTMP1.text = canonSlide1.value.ToString();
        bodyTMP1.text = bodySlide1.value.ToString();
        towerTMP1.text = towerSlide1.value.ToString();
        trucksTMP1.text = trucksSlide1.value.ToString();
        speedTMP1.text = (speedSlide1.value * 100).ToString("000") ;
        player1.UpdateSpeed(speedSlide1.value);
        
        tankUi1.typeBody = (int)bodySlide1.value;
        tankUi1.typeTower =(int)towerSlide1.value;
        tankUi1.typeTrucks =(int)trucksSlide1.value;
        tankUi1.typeCanon =(int)canonSlide1.value;
        tankUi1.UpdateImg();


       
        player2.typeCanon = (int)canonSlide2.value;
        player2.typeBody = (int)bodySlide2.value;
        player2.typeTower = (int)towerSlide2.value;
        player2.typeTrucks = (int)trucksSlide2.value;
        canonTMP2.text = canonSlide2.value.ToString();
        bodyTMP2.text = bodySlide2.value.ToString();
        towerTMP2.text = towerSlide2.value.ToString();
        trucksTMP2.text = trucksSlide2.value.ToString();
        speedTMP2.text = (speedSlide2.value * 100).ToString("000");
        player2.UpdateSpeed(speedSlide2.value);

        tankUi2.typeBody = (int)bodySlide2.value;
        tankUi2.typeTower = (int)towerSlide2.value;
        tankUi2.typeTrucks = (int)trucksSlide2.value;
        tankUi2.typeCanon = (int)canonSlide2.value;
        tankUi2.UpdateImg();





        Debug.Log("OnSlide1Change");
        
    }
    private void OnControllerButtonClicked1()
    {
        controllerPanel.SetActive(true);
        subController1Panel.SetActive(true);
        subController2Panel.SetActive(false);
        close1Button.gameObject.SetActive(true);
        close2Button.gameObject.SetActive(false);



        Debug.Log("OnControllerButtonClicked1");
    }
    private void OnControllerButtonClicked2()
    {
        
        controllerPanel.SetActive(true);
        subController1Panel.SetActive(false);
        subController2Panel.SetActive(true);
        close1Button.gameObject.SetActive(false);
        close2Button.gameObject.SetActive(true);

        Debug.Log("OnControllerButtonClicked2");
    }
}