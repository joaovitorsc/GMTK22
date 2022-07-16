using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody _PLayerRigidbody;
    public float _PlayerSpeed;
    public float _DashPlayerForce;

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
        var _movementHorizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(_movementHorizontal, 0, 0) * Time.deltaTime * _PlayerSpeed;
        
        var _movementVertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, 0, _movementVertical) * Time.deltaTime * _PlayerSpeed;
        
        Dash();
    }
    public void Dash()
    {
        if(Input.GetButtonDown("Jump"))
        {
            _PLayerRigidbody.AddForce(new Vector3(_DashPlayerForce, 0, 0), ForceMode.Impulse);
        }
    }
}
