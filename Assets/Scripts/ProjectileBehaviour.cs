using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float Speed = 4.5f;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.right * Speed;
    }

    void CheckBulletPos()
    {
        if(transform.position.x > 12.5)
        {
            Destroy(gameObject);
        }
    }
    public void Update()
    {
        CheckBulletPos();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        var enemyComp = collision.gameObject.GetComponent<EnemyManager>();
        if(enemyComp != null )
        {
            Destroy(enemyComp.gameObject);
        }

    }
    
}
