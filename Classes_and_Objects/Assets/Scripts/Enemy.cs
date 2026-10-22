using UnityEngine;
using System.Collections;
public class Enemy : MonoBehaviour
{
    public int hitpoints, damage;
    public string name;
    public Enemy(int hp, int dmg, string ID)
    {  //this constructor assigns hitpoints, damage, and name to    
       //the values passed into the constructor              
        hitpoints = hp;
        damage = dmg;
        name = ID;
    }
    public void TakeDamage()
    {
        hitpoints--; //reduce HP by 1 
        if (hitpoints < 1)

            Die();
         else
            GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color - new Color(0f,0.1f,0.1f,0f);
        Debug.Log(name + "'s HP: " + hitpoints); //print out new hp 

    }

    public void TakeDamage(int hpToReduce)  //this method is an overload which now takes a parameter
    {
        hitpoints = hitpoints - hpToReduce; //reduce HP by 1 
        if (hitpoints < 1)
            Die();
        else
            GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color - new Color(0f, 0.1f, 0.1f, 0f);
        Debug.Log(name + "'s HP: " + hitpoints); //print out new hp 
    }

    public void Die()
    {
        Debug.Log(name + " Has Died"); //print to the console 
    }
}

