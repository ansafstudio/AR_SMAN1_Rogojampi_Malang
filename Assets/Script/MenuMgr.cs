using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimplePopup;

public class MenuMgr : MonoBehaviour {

    public GameObject MainMenu;
    public GameObject Panduan;

    public AudioSource backsound;
    public AudioSource backsoundAR;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (MainMenu.activeSelf)
            {
                SimplePopupManager.Instance.CreatePopup("Are you sure want to quit?");
                SimplePopupManager.Instance.AddButton("Yes", delegate { Application.Quit(); });
                SimplePopupManager.Instance.AddButton("No", delegate { SimplePopupManager.Instance.HidePopup(); });
                SimplePopupManager.Instance.ShowPopup();
            }
            else
            {
                MainMenu.SetActive(true);
                Panduan.SetActive(false);

                if (backsoundAR.isPlaying)
                {
                    backsound.Play();
                    backsoundAR.Stop();
                }
            }
        }

        
		
	}

    public void StartAR()
    {
        MainMenu.SetActive(false);

        backsoundAR.Play();
        backsound.Stop();
    }

    public void OpenPanduan()
    {
        MainMenu.SetActive(false);
        Panduan.SetActive(true);
    }

    public void BackToMainmenu()
    {
        MainMenu.SetActive(true);
        Panduan.SetActive(false);
    }

    public void DownloadMarker()
    {
        Application.OpenURL("https://drive.google.com/open?id=1wI6qURq9yIXv_aOrlN2G2JSO1mDaPy4a");
    }


}
