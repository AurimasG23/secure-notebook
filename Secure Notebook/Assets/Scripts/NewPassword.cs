using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//edit password via settings
public class NewPassword : MonoBehaviour
{
    public GameObject changePasswordPanel;
    public InputField newPasswordField;
    public InputField confirmPasswordField;
    public GameObject passwordDidNotMatchNotification;
    public Button okButton;
    public GameObject LockChangedNotification;
    public GameObject LockSettingsMenuLayer;

    // Use this for initialization
    void Start ()
    {
        passwordDidNotMatchNotification.SetActive(false);
        LockChangedNotification.SetActive(false);
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
        if (newPasswordField.text != "" && confirmPasswordField.text != "")
        {
            if (newPasswordField.text == confirmPasswordField.text)
            {
                PlayerPrefs.SetString("Password", newPasswordField.text);
                newPasswordField.text = "";
                confirmPasswordField.text = "";
                changePasswordPanel.SetActive(false);
                LockChangedNotification.SetActive(true);
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
        LockChangedNotification.SetActive(false);
    }

    public void cancelLockChanging()
    {
        changePasswordPanel.SetActive(false);
        LockSettingsMenuLayer.SetActive(true);
        newPasswordField.text = "";
        confirmPasswordField.text = "";
    }
}
