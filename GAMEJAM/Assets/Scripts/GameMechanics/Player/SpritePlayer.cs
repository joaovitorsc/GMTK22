using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritePlayer : MonoBehaviour
{
    public GameObject Camera;
    void Update()
    {
        transform.LookAt(Camera.transform);
    }
}
