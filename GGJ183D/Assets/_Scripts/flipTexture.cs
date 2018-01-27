using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipTexture : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector3 scale = GetComponent<Renderer>().transform.localScale;
		scale.x = -scale.x;
		GetComponent<Renderer>().transform.localScale = scale;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
