using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    GameObject Player;
    public GameObject SpawnBullet, Bullet;
    GameObject SpawnDice;
    public float DistanceToShoot, DistanceToEscape, ForceJump, LifeEnemy;
    bool StartFire;
    public float DelayToShoot = 0.5F;
    private float NextDash = 0.0F;

    Rigidbody rigidbodyEnemy;

    private void Start()
    {
        rigidbodyEnemy = GetComponent<Rigidbody>();
        Player = GameObject.FindGameObjectWithTag("Player");
        SpawnDice = GameObject.FindGameObjectWithTag("SpawnDice");
    }
    private void Update()
    {
        transform.LookAt(Player.transform);
        SpawnBullet.transform.LookAt(Player.transform);
        if (LifeEnemy <= 0)
        {
            Death();
        }
        if (Vector3.Distance(this.transform.position, Player.transform.position) <= DistanceToShoot && Time.time > NextDash)
        {
            NextDash = Time.time + DelayToShoot;
            Attack();
        }
        if (Vector3.Distance(this.transform.position, Player.transform.position) <= DistanceToEscape)
        {
            MovementEnemy();
            Debug.Log("FOGEFDP");
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Dice")
        {
            Destroy(other.gameObject);
            LifeEnemy -= SpawnDice.GetComponent<Attack>().DamageDice;
            Debug.Log("Colidiu");
            SpawnDice.GetComponent<Attack>().RandomDice();

        }
    }
    void MovementEnemy()
    {
        rigidbodyEnemy.AddForce(-transform.forward * ForceJump);
    }
    void Attack()
    {
        
            Instantiate(Bullet, SpawnBullet.transform.position, SpawnBullet.transform.rotation);

        
    }
    void Death()
    {
        Destroy(gameObject);
    }
}
