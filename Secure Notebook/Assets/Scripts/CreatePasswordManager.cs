using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatePasswordManager : MonoBehaviour
{
    public GameObject createPasswordPanel;
    public InputField newPasswordField;
    public InputField confirmPasswordField;
    public GameObject passwordDidNotMatchNotification;
    public Button okButton;
    public GameObject passwordCreatedNotification;

	// Use this for initialization
	void Start ()
    {
        passwordDidNotMatchNotification.SetActive(false);
        passwordCreatedNotification.SetActive(false);

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (newPasswordField.text == "" || confirmPasswordField.text == "")
        {
            okButton.interactable = false;
        }
        else
        {
            okButton.interactable = true;
        }
	}

    public void pressCreateButton()
    {
        if(newPasswordField.text != "" && confirmPasswordField.text != "")
        {
            if(newPasswordField.text == confirmPasswordField.text)
            {
                PlayerPrefs.SetString("Password", newPasswordField.text);
                newPasswordField.text = "";
                confirmPasswordField.text = "";
                createPasswordPanel.SetActive(false);
                passwordCreatedNotification.SetActive(true);
            }
            else
            {
                newPasswordField.text = "";
                confirmPasswordField.text = "";
                passwordDidNotMatchNotification.SetActive(true);
            }
        }
    }

    //when password is successfuly created
    public void pressOkButton()
    {
        passwordCreatedNotification.SetActive(false);
    }
}
