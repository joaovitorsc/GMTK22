using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritePlayer : MonoBehaviour
{
    public GameObject Camera;
    Animator AnimatorPlayer;

    private void Start()
    {
        AnimatorPlayer = GetComponent<Animator>();
    }
    void Update()
    {
        transform.LookAt(Camera.transform);
        ChangeAnimations();
    }


    void ChangeAnimations()
    {
        if (Input.GetKey(KeyCode.A))
        {
             AnimatorPlayer.SetBool("Esquerda", true);
             AnimatorPlayer.SetBool("Direita", false);
            
             AnimatorPlayer.SetBool("Up", false);
             AnimatorPlayer.SetBool("Baixo", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            AnimatorPlayer.SetBool("Direita", true);
            AnimatorPlayer.SetBool("Esquerda", false);

            AnimatorPlayer.SetBool("Up", false);
            AnimatorPlayer.SetBool("Baixo", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            AnimatorPlayer.SetBool("Baixo", true);
            AnimatorPlayer.SetBool("Up", false);

            AnimatorPlayer.SetBool("Esquerda", false);
            AnimatorPlayer.SetBool("Direita", false);
        }

        if (Input.GetKey(KeyCode.W))
        {
            AnimatorPlayer.SetBool("Up", true);
            AnimatorPlayer.SetBool("Baixo", false);
           

            AnimatorPlayer.SetBool("Esquerda", false);
            AnimatorPlayer.SetBool("Direita", false);

        }
    }
}
