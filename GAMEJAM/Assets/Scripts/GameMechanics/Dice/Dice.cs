using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    Rigidbody rigidbodyDice;
    public float ThrowForce;
    public float TimerLeft;
    GameObject SpawnDice;
    GameObject maincamera;
 
    private void Start()
    {
        maincamera = GameObject.FindGameObjectWithTag("MainCamera");
        SpawnDice = GameObject.FindGameObjectWithTag("SpawnDice");
        Destroy(gameObject, 1f);
        rigidbodyDice = gameObject.GetComponent<Rigidbody>();
        rigidbodyDice.AddForce(transform.forward * ThrowForce, ForceMode.Impulse);
    }
    private void Update()
    {
        transform.LookAt(maincamera.transform);
        TimerLeft -= Time.deltaTime;
        if(TimerLeft<=0)
        {
            SpawnDice.GetComponent<Attack>().RandomDice();
        }
    }
}
