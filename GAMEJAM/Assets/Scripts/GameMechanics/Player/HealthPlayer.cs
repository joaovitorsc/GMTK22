using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    public GameObject[] Hearts;

    public int HealthPLayer;
    public GameObject PanelGameOver;

    private void Start()
    {
        HealthPLayer = Hearts.Length;
    }
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
        if (other.tag == "Enemy")
        {
            HealthPLayer--;
            Destroy(Hearts[HealthPLayer].gameObject);
            FindObjectOfType<AudioManager>().Play("DamagePlayer");
        }
        if (other.tag == "EnemyBullet")
        {
            HealthPLayer--;
            Destroy(Hearts[HealthPLayer].gameObject);
            FindObjectOfType<AudioManager>().Play("DamagePlayer");
            Destroy(other.gameObject);
        }
    }
}
