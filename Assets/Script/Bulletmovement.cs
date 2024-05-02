using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletmovement : MonoBehaviour
{

    private Vector2 direction;
    private Rigidbody2D rb2d;
    [SerializeField] private float speed;

    private void Awake()
    {
        rb2d= GetComponent<Rigidbody2D>();

    }


    public void SetDirection( Vector2 direction)
    {
        this.direction= direction;  
    }

    void Move()
    {
        rb2d.velocity = direction * speed;
    }


    // Update is called once per frame
    void Update()
    {
        Move();
        
    }
}
