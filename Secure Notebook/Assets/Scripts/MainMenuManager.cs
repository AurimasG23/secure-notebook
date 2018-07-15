using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public Button settingsButton;
    public GameObject SettingsMenuLayer;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onSettingsButtonClick()
    {

        SettingsMenuLayer.SetActive(true);
    }
}
