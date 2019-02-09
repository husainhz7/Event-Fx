using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    float timer = 3f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.fixedDeltaTime;
        if(timer <= 0)
        {
            Destroy(this.gameObject);
        }
        transform.localPosition += Vector3.forward;
	}
}
