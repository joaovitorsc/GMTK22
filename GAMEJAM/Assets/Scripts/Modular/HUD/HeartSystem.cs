using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] Hearts;
    int life;

    private void Start()
    {
        life = Hearts.Length;

    }
}
