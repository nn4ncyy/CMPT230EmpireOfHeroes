using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    public float MaxHitPoints = 5;

    private Animator animator;
  
    

    void Start()
    {
        health = MaxHitPoints;
        
    }

    
    public void TakeDamage(float damage)
    {
        health -= damage;

        if(health <= 0f)
        {
            
            Death();
            EnemyDeath();
            
        }
    }

    public void Death()
    {
        
        animator = GameObject.Find(gameObject.name).GetComponent<Animator>();
        animator.SetBool("isDead", true);
        
        
    }

    public void EnemyDeath()
    {
      
        Destroy(gameObject, 1f);
        Debug.Log(gameObject.name + "Died");
        
    }
}
