using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    private void OnTriggerEnter(Collider _collider)
    {
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter(Collision collision) {
        Rigidbody rigidBody = GetComponent<Rigidbody>();
        rigidBody.AddForce(collision.impulse, ForceMode.Impulse);
    }

}
