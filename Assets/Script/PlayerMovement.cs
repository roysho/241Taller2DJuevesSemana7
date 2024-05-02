using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float veritcal = Input.GetAxis("Vertical");
        rb2d.velocity = new Vector2(horizontal, veritcal).normalized * speed;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move(); 
    }
}
