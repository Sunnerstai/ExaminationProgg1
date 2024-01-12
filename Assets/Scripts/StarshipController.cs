using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEditor;
using UnityEngine;

public class StarshipController : MonoBehaviour
{
    public float Health = 100f;

    public ProjectileBehaviour ProjectilePrefab;
    public Transform LaunchOffset;

    [SerializeField] float moveSpeed = 5f;
    [SerializeField] Rigidbody2D rb; //rigidbody
    Vector2 movement;

    private void OnCollisionEnter(Collision collision)
    {  
        {
            TakeDamage(20f);
        }
    }
    private void TakeDamage(float damage)
    {
        HealthManager healthManager = GetComponent<HealthManager>();
        healthManager?.TakeDamage(damage);
    }


    private void Update() //input
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
        }
    }


    //private void FixedUpdate() //movement
    //{
    //    rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    //}

}

