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
        if(Input.GetKey(KeyCode.A))
        {
            AnimatorPlayer.SetBool("Esquerda", true);
            AnimatorPlayer.SetBool("Direita", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            AnimatorPlayer.SetBool("Direita", true);
            AnimatorPlayer.SetBool("Esquerda", false);
        }
    }
}
