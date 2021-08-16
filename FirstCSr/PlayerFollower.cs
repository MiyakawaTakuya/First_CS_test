using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerFollower : MonoBehaviour {  
	Vector3 offset;

	// Use this for initialization
	void Start () {  
		offset = this.transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		this.transform.position = player.transform.position + offset;
	}
}
