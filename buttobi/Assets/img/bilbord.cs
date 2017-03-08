using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class bilbord : MonoBehaviour {

    public Camera targetCamera;
    private bool enableVerticalRotation;

    // Use this for initialization
    void Start () {

        //対象のカメラが指定されない場合にはMainCameraを対象とします。
        if (this.targetCamera == null)
            targetCamera = Camera.main;

    }
	
	// Update is called once per frame
	void Update () {
        //上下方向へは回転しないように抑制する場合。
        if (enableVerticalRotation)
        {
            this.transform.LookAt(this.targetCamera.transform.position);
        }
        else
        {
            Vector3 target = this.targetCamera.transform.position;
            target.y = this.transform.position.y;
            this.transform.LookAt(target);
        }
    }
}
