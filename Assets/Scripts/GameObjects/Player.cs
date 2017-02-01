using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float moveSpeed = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.position = new Vector3(transform.position.x, 
				transform.position.y + moveSpeed*Time.deltaTime,
				transform.position.z);
		}
	}
}
