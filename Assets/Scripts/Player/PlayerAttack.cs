using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Rigidbody2D rb;

    // Weapon Variables
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firingPoint;
    [Range(0.1f,1f)]
    [SerializeField] private float firingRate = 0.5f;
    private float fireTimer;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, firingPoint.position, firingPoint.rotation);
    }

    void Update()
    {
        if(Input.GetMouseButton(0) && fireTimer <= 0f)
        {
            Shoot();
            fireTimer = firingRate;
        }
        else
        {
            fireTimer -= Time.deltaTime;
        }
    }
}
