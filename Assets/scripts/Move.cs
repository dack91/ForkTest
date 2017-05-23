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

	// 3rd comment
	// 2nd comment
	// asfkawseifvojwsvi
	// Update is called once per frame
	void Update () {
        locX = Mathf.Sin(Time.time);
        trans.position = new Vector3(locX, trans.position.y, trans.position.z);
	}
}
