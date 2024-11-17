using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject Player;
    private Rigidbody PRb;
    public float speed = 10;
    public int maxDistance = 100;
    private bool Grounded = false;
    public Rigidbody rb;
    private Vector3 distance;

    private void Start()
    {
        Player = GameObject.FindWithTag("Player");
        PRb = GameObject.FindWithTag("Player").gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        distance = (Player.transform.position + new Vector3(0, 0.5f, 0)) - transform.position;
    }
    private void FixedUpdate()
    {
        transform.LookAt(Player.transform.position + new Vector3(0, 2, 0));
        if (distance.x > maxDistance || distance.y > maxDistance || distance.z > maxDistance)
        {
            transform.position += distance / 1.6f;
        }
        if (Grounded)
        {
            rb.AddForce(transform.forward * speed * 10000 * Time.deltaTime, ForceMode.Force);
            //rb.velocity *= 0.95f;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Rigidbody PRb = Player.GetComponent<Rigidbody>();
            //Vector3 oldPlayerVelocity = PlayerRb.velocity;
            rb.velocity += -rb.velocity * 1.2f;
            //rb.velocity += -PRb.velocity * 0.8f;
            //PlayerRb.velocity = oldPlayerVelocity * 1.1f;
        }
        if (other.gameObject.tag == "Ground")
        {
            Grounded = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Grounded = false;
        }
    }
}