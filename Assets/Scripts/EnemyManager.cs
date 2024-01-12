using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public float Speed = 2f;
    public float HP = 40f;
    // Start is called before the first frame update
    void Start()
    {

    }
    void CheckEnemyPos()
    {
        if (transform.position.x < -9)
        {
            Destroy(gameObject);
        }
    }
    public void Update()
    {
        CheckEnemyPos();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = -transform.right * Speed;
    }
}
