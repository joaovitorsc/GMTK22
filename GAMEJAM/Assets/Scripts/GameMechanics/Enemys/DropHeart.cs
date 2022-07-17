using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropHeart : MonoBehaviour
{
    GameObject Player, Camera;
    

    private void Start()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        transform.LookAt(Camera.transform);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Player.GetComponent<HealthPlayer>().HealthPLayer++;
            Destroy(gameObject);
        }
    }
}
