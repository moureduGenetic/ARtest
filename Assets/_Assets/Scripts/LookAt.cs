﻿using UnityEngine;

public class LookAt : MonoBehaviour {	
	// Update is called once per frame
	void Update () {
        transform.LookAt(Camera.main.transform, Vector3.up);
	}
}
