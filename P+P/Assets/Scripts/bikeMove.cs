using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bikeMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(this.transform.up * 0.1f);
        if (Input.GetKey(KeyCode.RightArrow))
            this.transform.Rotate(new Vector3(0, 0, -1f));
        if (Input.GetKey(KeyCode.LeftArrow))
            this.transform.Rotate(new Vector3(0, 0, 1f));
    }
}
