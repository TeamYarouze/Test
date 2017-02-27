﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class kingcontrol : MonoBehaviour , IPointerClickHandler
{

    Rigidbody rigidBody;
    public Vector3 force = new Vector3(0, 10, 0);
    public ForceMode forceMode = ForceMode.VelocityChange;

    // Use this for initialization
    void Start () {
        //rigidbodyを取得する。
        rigidBody = gameObject.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	public void OnPointerClick(PointerEventData eventData)
    {
        //力を加える。
        rigidBody.AddForce(force, forceMode);
    }
}
