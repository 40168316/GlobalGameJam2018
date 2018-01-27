using UnityEngine;
using System.Collections;

// Sandbox Mgr will spawn the babies somewhere on the map
// Remains stationary until player within range and calls
// Sends out calls at random intervals, and when player within range

public class BabyWhaleBehaviour : MonoBehaviour
{
    // Has this child been found
    bool found = false;

    private void OnTriggerStay(Collider other)
    {
        // If the collision is with player
        if (other.tag == "Player" && found == false)
        {
            // Parent to player when behind
            if (Vector3.Distance(transform.position, other.transform.position) > 4)
            {
               
                // This baby has been found; move to just behind player
                // Don't take Y axis into account
                Vector3 target = new Vector3(other.transform.position.x + 2, transform.position.y, other.transform.position.z);
                transform.LookAt(target);
                transform.position += transform.forward * 5.0f * Time.deltaTime;

            }
            // Otherwise, parent to play now within range
            else
            {
                transform.SetParent(other.transform);
                Debug.Log("Parented");
                found = true;
            }
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
