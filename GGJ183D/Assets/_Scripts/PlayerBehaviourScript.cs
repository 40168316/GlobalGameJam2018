using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour {

	public Rigidbody2D rb;

	float  health;
	int mass;
	float velocity;
	float turnSpeed;

	//Whalesongs/pitches array?

	bool canTransmit = true; 			//Cooldown
	bool powerup1IsActive = false;		//Cooldown
	bool powerup2IsActive = false;		//Cooldown

	bool isBleeding = false;



	// Use this for initialization
	void Start () {
		health = 100.0f;
			
		turnSpeed = 100.0f;
		velocity = 10.0f;
	}
	
	// Update is called once per frame
	void Update () {
        PlayerInput();	
	}




	void PlayerInput()
	{
		float rotation = Input.GetAxis ("Horizontal") * turnSpeed * Time.deltaTime;

		transform.Rotate (0, rotation, 0);

		if(Input.GetKey(KeyCode.Space))
		{
			transform.position += transform.forward * velocity * Time.deltaTime;
		}
	}
}
