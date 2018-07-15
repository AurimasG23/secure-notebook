using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    public GameObject settingsMenuLayer;
    public GameObject lockSettingsLayer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onBackButtonClick()
    {
        settingsMenuLayer.SetActive(false);
    }

    public void onLockSettingsButtonClick()
    {
        lockSettingsLayer.SetActive(true);
    }
}
