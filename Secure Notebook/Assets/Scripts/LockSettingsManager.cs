using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockSettingsManager : MonoBehaviour
{
    public GameObject LockSettingsMenuLayer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onBackButtonClick()
    {
        LockSettingsMenuLayer.SetActive(false);
    }
}
