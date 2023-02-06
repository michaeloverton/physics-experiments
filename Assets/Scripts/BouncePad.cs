using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePad : MonoBehaviour
{
    [SerializeField] float bounceForce = 10f;

    void OnTriggerEnter(Collider other)
    {
        other.attachedRigidbody.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
    }
}
