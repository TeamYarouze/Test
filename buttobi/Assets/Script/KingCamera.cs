using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingCamera : MonoBehaviour {

    private GameObject king = null;
    public Vector3 camRelPos = new Vector3(0.0f, 0.0f, 0.0f);

	// Use this for initialization
	void Start () {
		king = GameObject.Find("king");
	}
	
	// Update is called once per frame
	void Update () {
		
        if( !king ) return;

        Vector3 camPos = king.transform.position;

        camPos.x += camRelPos.x;
        camPos.y += camRelPos.y;
        camPos.z += camRelPos.z;
        transform.position = camPos;
	}
}
