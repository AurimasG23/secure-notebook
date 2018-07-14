using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordManager : MonoBehaviour
{
    public GameObject passwordPanel;
    public InputField passwordInputField;
    public GameObject wrongPasswordNotification;
    public Button okButton;

	// Use this for initialization
	void Start ()
    {
        wrongPasswordNotification.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(passwordInputField.text == "")
        {
            okButton.interactable = false;
        }
        else
        {
            okButton.interactable = true;
        }
	}

    public void pressOkButton()
    {
        if (PlayerPrefs.HasKey("Password"))
        {
            if(passwordInputField.text == PlayerPrefs.GetString("Password"))
            {
                passwordPanel.SetActive(false);
                wrongPasswordNotification.SetActive(false);
                passwordInputField.text = "";
            }
            else
            {
                wrongPasswordNotification.SetActive(true);
                passwordInputField.text = "";
            }
        }
    }
}
