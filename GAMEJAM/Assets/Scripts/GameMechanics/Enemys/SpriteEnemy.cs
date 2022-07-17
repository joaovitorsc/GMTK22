using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteEnemy : MonoBehaviour
{
   
    GameObject Player, MainCamera;
    Animator EnemyAnimator;
    Enemy1 Enemy;

    private void Start()
    {
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        Player = GameObject.FindGameObjectWithTag("Player");
        EnemyAnimator = gameObject.GetComponent<Animator>();
        Enemy = gameObject.GetComponentInParent<Enemy1>();
        
        EnemyAnimator.SetBool("Idle", true);
    }
    private void Update()
    {
        transform.LookAt(MainCamera.transform);
        ChangeAnimationsEnemy();
    }
    void ChangeAnimationsEnemy()
    {
        if (Enemy.FollowPlayer)
        {
            if (Player.transform.position.x <= transform.parent.position.x && Player.transform.position.z <= transform.parent.position.z + 10f)
            {
                EnemyAnimator.SetBool("Esquerda", true);
                EnemyAnimator.SetBool("Direita", false);

                EnemyAnimator.SetBool("Up", false);
                EnemyAnimator.SetBool("Baixo", false);
                EnemyAnimator.SetBool("Idle", false);
                EnemyAnimator.SetBool("Attack", false);
            }
            if (Player.transform.position.x >= transform.parent.position.x && Player.transform.position.z >= transform.parent.position.z - 10f)
            {
                EnemyAnimator.SetBool("Direita", true);
                EnemyAnimator.SetBool("Esquerda", false);

                EnemyAnimator.SetBool("Up", false);
                EnemyAnimator.SetBool("Baixo", false);
                EnemyAnimator.SetBool("Idle", false);
                EnemyAnimator.SetBool("Attack", false);
            }
            
            if (Player.transform.position.z <= transform.parent.position.z && Player.transform.position.x <= transform.parent.position.x + 10f)
            {
                EnemyAnimator.SetBool("Baixo", true);
                EnemyAnimator.SetBool("Up", false);

                EnemyAnimator.SetBool("Esquerda", false);
                EnemyAnimator.SetBool("Direita", false);
                EnemyAnimator.SetBool("Idle", false);
                EnemyAnimator.SetBool("Attack", false);
            }
            if (Player.transform.position.z >= transform.parent.position.z && Player.transform.position.x >= transform.parent.position.x + 10f)
            {
                EnemyAnimator.SetBool("Up", true);
                EnemyAnimator.SetBool("Baixo", false);


                EnemyAnimator.SetBool("Esquerda", false);
                EnemyAnimator.SetBool("Direita", false);
                EnemyAnimator.SetBool("Idle", false);
                EnemyAnimator.SetBool("Attack", false);
            }

        }
    }
}
