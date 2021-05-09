using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputChanger : MonoBehaviour
{
    //TODO: Change everything from Standard Input System to the new Input System

    public static InputChanger Instance;
    [SerializeField] private GameObject selectInputModePanel;


    //public Transform menuPanel;
    //Event keyEvent;
    //TextMeshProUGUI buttonText;
    //KeyCode newKey;

    //bool waitingForKey;

    //public KeyCode jump { get; set; }
    //public KeyCode left { get; set; }
    //public KeyCode right { get; set; }
    //public KeyCode attack { get; set; }

    private void Awake()
    {
        //Create the singleton
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }       

        //    jump = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("jumpKey", "Space"));
        //    left = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("leftKey", "A"));
        //    right = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("rightKey", "D"));
        //    attack = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("attackKey", "Mouse0"));
    }

    private void Start()
    {
        InputManager.Instance.onPause.AddListener(Pause);
        selectInputModePanel.SetActive(false);
    }

    //void Start()
    //{
    //    menuPanel.gameObject.SetActive(false);
    //    waitingForKey = false;

    //    for(int i = 0; i < menuPanel.childCount; i++)
    //    {
    //        if(menuPanel.GetChild(i).name == "Move Left Group")
    //        {
    //            menuPanel.GetChild(i).GetChild(1).GetComponentInChildren<TextMeshProUGUI>().text = left.ToString();
    //        }
    //        else if (menuPanel.GetChild(i).name == "Move Right Group")
    //        {
    //            menuPanel.GetChild(i).GetChild(1).GetComponentInChildren<TextMeshProUGUI>().text = right.ToString();
    //        }
    //        else if (menuPanel.GetChild(i).name == "Jump Group")
    //        {
    //            menuPanel.GetChild(i).GetChild(1).GetComponentInChildren<TextMeshProUGUI>().text = jump.ToString();
    //        }
    //        else if (menuPanel.GetChild(i).name == "Attack Group")
    //        {
    //            menuPanel.GetChild(i).GetChild(1).GetComponentInChildren<TextMeshProUGUI>().text = attack.ToString();
    //        }
    //    }
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if(Input.GetKeyDown(KeyCode.Escape) && !menuPanel.gameObject.activeSelf)
    //    {
    //        menuPanel.gameObject.SetActive(true);
    //    }
    //    else if (Input.GetKeyDown(KeyCode.Escape) && menuPanel.gameObject.activeSelf)
    //    {
    //        menuPanel.gameObject.SetActive(false);
    //    }
    //}

    //private void OnGUI()
    //{
    //    keyEvent = Event.current;

    //    if(keyEvent.isKey && waitingForKey)
    //    {
    //        newKey = keyEvent.keyCode;
    //        waitingForKey = false;
    //    }
    //}

    //public void StartAssignment(string keyName)
    //{
    //    if (!waitingForKey)
    //    {
    //        StartCoroutine(AssignKey(keyName));
    //    }
    //}

    //public void SendText(TextMeshProUGUI text)
    //{
    //    buttonText = text;
    //}

    public void ChangeInputMethod(string method)
    {
        if (method == "Keyboard")
        {
            InputManager.Instance.inputController.Gameplaycontroller.Disable();
            InputManager.Instance.inputController.Gameplaykeyboard.Enable();
        }
        else if (method == "Gamepad")
        {
            InputManager.Instance.inputController.Gameplaykeyboard.Disable();
            InputManager.Instance.inputController.Gameplaycontroller.Enable();
        }
    }

    private void Pause()
    {
        selectInputModePanel.SetActive(!selectInputModePanel.activeInHierarchy);
    }

    //IEnumerator WaitForKey()
    //{
    //    while (!keyEvent.isKey)
    //    {
    //        yield return null;
    //    }
    //}

    //public IEnumerator AssignKey(string keyName)
    //{
    //    waitingForKey = true;

    //    yield return WaitForKey();

    //    switch (keyName)
    //    {
    //        case "left":
    //            left = newKey;
    //            buttonText.text = left.ToString();
    //            PlayerPrefs.SetString("leftKey", left.ToString());
    //            break;
    //        case "right":
    //            right = newKey;
    //            buttonText.text = right.ToString();
    //            PlayerPrefs.SetString("rightKey", right.ToString());
    //            break;
    //        case "jump":
    //            jump = newKey;
    //            buttonText.text = jump.ToString();
    //            PlayerPrefs.SetString("jumpKey", jump.ToString());
    //            break;
    //        case "attack":
    //            attack = newKey;
    //            buttonText.text = attack.ToString();
    //            PlayerPrefs.SetString("attackKey", attack.ToString());
    //            break;
    //    }

    //    yield return null;
    //}
}
