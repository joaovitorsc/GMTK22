using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject Dice;

    private void Update()
    {
        AttackDice();
    }
    void AttackDice()
    {
        
        if(Input.GetMouseButtonDown(0))
        Instantiate(Dice,this.transform.position,this.transform.rotation);
    }
}
