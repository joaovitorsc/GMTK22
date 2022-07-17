using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    Transform PositionPlayer;
    Rigidbody rigidbodyEnemy;
    public int LifeEnemy;
    public float SpeedEnemy, DashForce;
    GameObject Player, SpawnDice;
    public float DelayTimeToDash = 0.5F;
    private float NextDash = 0.0F;
    public bool FollowPlayer;

    private void Start()
    {
        
        rigidbodyEnemy = gameObject.GetComponent<Rigidbody>();
        FollowPlayer = false;
        SpawnDice = GameObject.FindGameObjectWithTag("SpawnDice");
        Player = GameObject.FindGameObjectWithTag("Player");
        PositionPlayer = Player.transform;
    }
    private void Update()
    {
        MovementEnemy();
        if(LifeEnemy<=0)
        {
            DeathEnemy();
        }
        if (Vector3.Distance(this.transform.position, Player.transform.position) <= 8f)
        {
            FollowPlayer = true;
        }
    }
    void MovementEnemy()
    {
        if (FollowPlayer)
        {
            transform.LookAt(PositionPlayer.transform);
            transform.Translate(Vector3.forward * SpeedEnemy * Time.deltaTime);
        }
        if (Vector3.Distance(this.transform.position, Player.transform.position) <= 6f  && Time.time > NextDash)
        { 
            NextDash = Time.time + DelayTimeToDash; 
            DashEnemy();
        }

    }
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Dice")
        {
            FindObjectOfType<AudioManager>().Play("EnemyHurt");
            Destroy(other.gameObject);
            LifeEnemy -= SpawnDice.GetComponent<Attack>().DamageDice;
            Debug.Log("Colidiu");
            SpawnDice.GetComponent<Attack>().RandomDice();
          
        }
    }
    void DeathEnemy()
    {
            Destroy(gameObject);
    }
    void DashEnemy()
    {
        rigidbodyEnemy.AddForce(transform.forward * DashForce, ForceMode.Impulse);
    }
}
