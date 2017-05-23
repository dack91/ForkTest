using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public GameObject obj;
    private Transform trans;

    public float speed = 10;
    private float locX;

	// Use this for initialization
	void Start () {
        trans = obj.GetComponent<Transform>();
        locX = trans.position.x;
	}
	
    // comment in conflicting line with artemis' change
	// Update is called once per frame
	void Update () {
        locX = Mathf.Cos(Time.time * 10);            // change from sin to cos and speed up movement
        trans.position = new Vector3(locX, trans.position.y, trans.position.z);
	}
}
