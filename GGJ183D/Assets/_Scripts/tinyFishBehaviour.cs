using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tinyFishBehaviour : MonoBehaviour {

	private float heigth = 2.0f;
	private float strength = 100.0f;
	private float rangeSin = 0.05f;
	private bool flipTexture = false;
	private Renderer thisRend;
	private Vector3 scale;

	private Vector3 tempPos;

	// Use this for initialization
	void Start () {
		tempPos = transform.position;
		Random.InitState (System.DateTime.Now.Millisecond);
		heigth = Random.Range (2.0f, 2.21f);
		tempPos.y = heigth;
		thisRend = GetComponentInChildren<Renderer> ();
		scale = thisRend.transform.localScale;
	}

	// Update is called once per frame
	void Update () {
		tempPos.x = Mathf.Sin (Time.realtimeSinceStartup * rangeSin) * strength;
		Debug.Log (Mathf.Sin (Time.realtimeSinceStartup * rangeSin) * strength);
		transform.position = tempPos;
		if (tempPos.x > 98.0f) 
		{
			flipTexture = true;
			scale.x = -scale.x;
			thisRend.transform.localScale = scale;
		}
		else if (tempPos.x < -98.0f)
		{
			flipTexture = false;
			scale.x = -scale.x;
			thisRend.transform.localScale = scale;
		}


	}
}
