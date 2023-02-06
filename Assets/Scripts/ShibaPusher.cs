using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShibaPusher : MonoBehaviour
{
    [SerializeField] float pushForce = 1f;
    GameObject player;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("RigidBodyFPSController");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 shibaToPlayer = player.transform.position - transform.position;
        rb.AddForce(-pushForce * shibaToPlayer, ForceMode.Force);
    }
}
