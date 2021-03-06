﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class list_nameHolder : MonoBehaviour {
    
    public GameObject parent;
    public Camera MainCamera;
    private Vector3 namePos;

    public Vector3 offset;

	// Use this for initialization
	void Start () {
        transform.parent = GameObject.Find("Canvas").transform;
        namePos = MainCamera.WorldToScreenPoint(parent.transform.position + offset);
        transform.position = namePos;
    }
	
	// Update is called once per frame
	void Update () {
        namePos = MainCamera.WorldToScreenPoint(parent.transform.position + offset);
        transform.position = namePos;
    }
}
