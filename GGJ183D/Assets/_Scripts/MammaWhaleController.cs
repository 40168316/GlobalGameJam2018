using UnityEngine;
using System.Collections;

public class MammaWhaleController : MonoBehaviour {

    private float moveSpeed = 5.0f;
    private float turnSpeed = 100.0f;

	
	// Update is called once per frame
	void Update () {

        // Listen for input
        PlayerInput();
	}


    private void PlayerInput()
    {
        // Listen for rotation via A/D, L/R keys
        float rotation = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        // Rotate by above calculated amount
        transform.Rotate(0, rotation, 0);
        // Listen for space being held
        if (Input.GetKey(KeyCode.Space))
        {
            // Move forwards
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
    }
}
