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

	// Use this for initialization
	void Start ()
    {
        passwordDidNotMatchNotification.SetActive(false);
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

    public void pressOkButton()
    {
        if(newPasswordField.text != "" && confirmPasswordField.text != "")
        {
            if(newPasswordField.text == confirmPasswordField.text)
            {

            }
            else
            {
                newPasswordField.text = "";
                confirmPasswordField.text = "";
                passwordDidNotMatchNotification.SetActive(true);
            }
        }
    }
}
