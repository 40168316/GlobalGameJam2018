using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyFishMovement : MonoBehaviour {

	private float hSpeed = 0.8f;
	private float vSpeed = 2.0f;
	private float strength = 1.5f;

	private Vector3 tempPos;

	// Use this for initialization
	void Start () {
		tempPos = transform.position;
		Random.InitState (System.DateTime.Now.Millisecond);
		hSpeed = Random.Range (0.5f, 1.0f);
		vSpeed = Random.Range (1.0f, 2.0f);
		strength = Random.Range (0.5f, 1.5f);


	}

	// Update is called once per frame
	void Update () {
		tempPos.x = Mathf.Sin (Time.realtimeSinceStartup * hSpeed) * strength;
		tempPos.z = Mathf.Sin (Time.realtimeSinceStartup * vSpeed) * strength;
		transform.position = tempPos;
	}
}
