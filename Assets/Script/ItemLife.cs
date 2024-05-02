using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLife : MonoBehaviour
{
    [SerializeField] int PowerLife;
    PlayerLife playerlife;


    private void Awake()
    {
        playerlife = GameObject.Find("Player").GetComponent<PlayerLife>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            playerlife.RecuperarVida(PowerLife);
            Destroy(gameObject);


        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
