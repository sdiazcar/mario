using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("One Shot");
	}
	
	// Update is called once per frame
	void Update () {
        print(Time.time);

        this.transform.position = new Vector3(Time.time, Mathf.Sin (Time.time) * 5, 0);
    }
}
