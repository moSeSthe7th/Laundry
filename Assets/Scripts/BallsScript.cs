using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsScript : MonoBehaviour
{
    Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
        rigidbody.velocity = Vector3.zero;
    }
}
