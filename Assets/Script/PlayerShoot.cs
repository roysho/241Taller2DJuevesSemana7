using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;

    private PlayerMovement playerMovement;
    float shootTimer;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Shoot()
    {
        shootTimer += Time.deltaTime;
        if (shootTimer >= 0.5)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject obj = Instantiate(bulletPrefab);
                obj.transform.position = transform.position;
                obj.GetComponent<Bulletmovement>().SetDirection(playerMovement.Direction.normalized);
                shootTimer = 0;
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        Shoot();
    }
}
