using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockSettingsManager : MonoBehaviour
{
    public GameObject LockSettingsMenuLayer;
    public GameObject SetPasswordLayer;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onPasswordButtonClick()
    {
        LockSettingsMenuLayer.SetActive(false);
        SetPasswordLayer.SetActive(true);
    }

    public void onBackButtonClick()
    {
        LockSettingsMenuLayer.SetActive(false);      
    }
}
