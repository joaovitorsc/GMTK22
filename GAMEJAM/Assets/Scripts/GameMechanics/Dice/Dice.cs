using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    Rigidbody rigidbodyDice;
    public float ThrowForce;
    public float TimerLeft;
    GameObject SpawnDice;
 
    private void Start()
    {
        SpawnDice = GameObject.FindGameObjectWithTag("SpawnDice");
        Destroy(gameObject, 1f);
        rigidbodyDice = gameObject.GetComponent<Rigidbody>();
        rigidbodyDice.AddForce(transform.forward * ThrowForce, ForceMode.Impulse);
    }
    private void Update()
    {
        TimerLeft -= Time.deltaTime;
        if(TimerLeft<=0)
        {
            SpawnDice.GetComponent<Attack>().RandomDice();
        }
    }
}
