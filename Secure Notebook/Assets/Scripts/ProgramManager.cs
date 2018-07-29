using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgramManager : MonoBehaviour
{
    public GameObject menuLayer;
    public GameObject createPasswordLayer;
    public GameObject passwordLayer;


	// Use this for initialization
	void Start ()
    {
        if (PlayerPrefs.HasKey("FirstTime") == false)
        {
            createPasswordLayer.SetActive(true);
        }
        else if(PlayerPrefs.HasKey("LockType") && PlayerPrefs.GetInt("LockType") == 1)
        {
            passwordLayer.SetActive(true);
        }
        menuLayer.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
