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
<<<<<<< HEAD

	// 3rd comment
	// 2nd comment
	// asfkawseifvojwsvi
=======
	
    // comment in conflicting line with artemis' change
>>>>>>> 6692f71e6866a553038675c0a69e0e45c9dfcddd
	// Update is called once per frame
	void Update () {
        locX = Mathf.Cos(Time.time * 10);            // change from sin to cos and speed up movement
        trans.position = new Vector3(locX, trans.position.y, trans.position.z);
	}
}
