using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour {
    public GameObject Objek;

    bool rotatedRight;
    bool rotatedLeft;

    bool isZoomIn;
    bool isZoomOut;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (rotatedRight)
        {
            Objek.transform.Rotate(Vector3.up, 100.0f * Time.deltaTime);
        }
        else if (rotatedLeft)
        {
            Objek.transform.Rotate(Vector3.down, 100.0f * Time.deltaTime);
        }

        if (isZoomIn)
        {
            Objek.transform.localScale += new Vector3(0.0001f, 0.0001f, 0.0001f);
        }
        else if (isZoomOut)
        {
            Objek.transform.localScale -= new Vector3(0.0001f, 0.0001f, 0.0001f);
        }
    }

    public void RotateRightPressed()
    {
        rotatedRight = true;
    }

    public void RotateRightReleased()
    {
        rotatedRight = false;
    }

    public void RotateLeftPressed()
    {
        rotatedLeft = true;
    }

    public void RotateLeftReleased()
    {
        rotatedLeft = false;
    }

    //Zoom
    public void ZoomINPressed()
    {
        isZoomIn = true;
    }
    public void ZoomINReleased()
    {
        isZoomIn = false;
    }

    public void ZoomOUTPressed()
    {
        isZoomOut = true;
    }
    public void ZoomOUTReleased()
    {
        isZoomOut = false;
    }

}
