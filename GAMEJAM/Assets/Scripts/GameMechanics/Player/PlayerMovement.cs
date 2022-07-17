using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody _PLayerRigidbody;
    public float _PlayerSpeed;
    public float _DashPlayerForce;
    public float _RotationSpeed;
    public GameObject _aimPlayer;
    private Vector3 movementDirection;
    bool Walking;

    private void Start()
    {
        _PLayerRigidbody = this.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
    }
    public void Move()
    {
       if(Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            FindObjectOfType<AudioManager>().Play("Walk");
        }
        float _movementHorizontal = Input.GetAxis("Horizontal");
        float _movementVertical = Input.GetAxis("Vertical");
        movementDirection = new Vector3(_movementHorizontal, 0, _movementVertical);
        movementDirection.Normalize();

        transform.Translate(movementDirection * _PlayerSpeed * Time.deltaTime, Space.World);

        if(movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, _RotationSpeed * Time.deltaTime);
        }

        Dash();
    }
    public void Dash()
    {
        if(Input.GetButtonDown("Jump"))
        {
            _PLayerRigidbody.AddForce(movementDirection * _DashPlayerForce, ForceMode.Impulse);
        }
    } 
}

