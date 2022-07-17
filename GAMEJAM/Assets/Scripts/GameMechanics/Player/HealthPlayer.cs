using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    public int HealthPLayer;
    public GameObject PanelGameOver;

    private void Update()
    {
        if(HealthPLayer <=0)
        {
            PanelGameOver.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy" || other.tag == "EnemyBullet")
        {
            Debug.Log("Dano");
            FindObjectOfType<AudioManager>().Play("DamagePlayer");
            HealthPLayer--;
        }
    }
}
