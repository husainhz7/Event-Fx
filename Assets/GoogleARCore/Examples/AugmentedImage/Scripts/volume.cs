using GoogleARCore;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volume : MonoBehaviour {

    public AugmentedImage Image;
    public GameObject obj;
    public GameObject dragon;
    int state = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Image == null || Image.TrackingState != TrackingState.Tracking)
        {
            obj.SetActive(false);
            dragon.SetActive(false);
            return;
        }
        obj.SetActive(true);
        Debug.Log(state);
        if(state >= 1)
        {
            dragon.SetActive(true);
        }
    }

    public void increment()
    {
        Debug.Log("Clicked");
        state++;
    }
}
