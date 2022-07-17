using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject Dice;
    public GameObject DiceToRandom;
    public int RandomNumberDiceDamage, DamageDice;

    public float fireRate = 0.5F;
    private float nextFire = 0.0F;
    Animator RotateDice;
    public float DelayToShoot;

    private void Start()
    {
        //DiceToRandom.SetActive(false);
        RotateDice = DiceToRandom.GetComponent<Animator>();
        RandomDice();
    }

    private void Update()
    {
        AttackDice();
    }
    void AttackDice()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(Dice, this.transform.position, this.transform.rotation);
           
            //RotateDice.Play("");
        }
    }
   public void RandomDice()
    {
        
        //DiceToRandom.SetActive(true);
        RandomNumberDiceDamage = Random.Range(1, 7);

        switch(RandomNumberDiceDamage)
        {
            case 1:
                RotateDice.Play("RotateDice6");
               
            break;
            case 2:
                RotateDice.Play("RotateDice5");
           
                break;
            case 3:
                RotateDice.Play("RotateDice4");
                
                break;
            case 4:
                RotateDice.Play("RotateDice3");
              
                break;
            case 5:
                RotateDice.Play("RotateDice2");
                
                break;
            case 6:
                RotateDice.Play("RotateDice1");
               
                break;
        }

        DamageDice = RandomNumberDiceDamage;
    }

}
