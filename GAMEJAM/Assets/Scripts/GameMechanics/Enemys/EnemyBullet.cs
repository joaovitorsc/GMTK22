using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public  float SpeedBullet;

    private void Start()
    {
        Destroy(gameObject, 1f);
    }
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * SpeedBullet);
    }
}
