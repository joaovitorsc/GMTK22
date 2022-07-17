using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    public int HealthPLayer;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Debug.Log("Dano");
            FindObjectOfType<AudioManager>().Play("DamagePlayer");
            HealthPLayer--;
        }
    }
}
