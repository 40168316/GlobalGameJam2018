using UnityEngine;
using System.Collections;

// Sandbox Mgr will spawn the babies somewhere on the map
// Remains stationary until player within range and calls
// Sends out calls at random intervals, and when player within range

public class BabyWhaleBehaviour : MonoBehaviour {


    private void OnTriggerStay(Collider other)
    {
        // If the collision is with player
        if (other.tag == "Player")
        { 
            // This baby has been found; move to just behind player
            transform.LookAt(other.transform);
            transform.position += transform.forward * 5.0f * Time.deltaTime;
            // Rotate to face the same way

            // Parent to player
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
