using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] private int life;
    float damageTimer;


    void DamageMuro(int valor)
    {
        life = life - valor;

    }

    public void DamageBalaEnemiga()
    {

    }

    public void RecuperarVida(int valor)
    {
        life += valor;
    }



    void Life()
    {
        
        if (life <= 0) 
        {
            Destroy(gameObject);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
            
            if (collision.gameObject.CompareTag("Muro"))
            {
                DamageMuro(1);
                
            }
            
        

        
    }

       

    // Update is called once per frame
    void Update()
    {

        Life();
        //damageTimer += Time.deltaTime;

    }
}
