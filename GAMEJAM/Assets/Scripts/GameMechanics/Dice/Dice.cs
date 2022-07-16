using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    Rigidbody rigidbodyDice;
    public float ThrowForce; 

    private void Start()
    {
        rigidbodyDice = gameObject.GetComponent<Rigidbody>();
        Destroy(gameObject, 1f);

        rigidbodyDice.AddForce(transform.forward * ThrowForce, ForceMode.Impulse);
    }

}
