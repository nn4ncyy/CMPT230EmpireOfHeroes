using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyChase : MonoBehaviour
{
    public GameObject player;
    private SpriteRenderer sprite;
    public float speed;

    private float distance;

    private Animator animator;
    
   
    void Start()
    {
        animator = GameObject.Find("Skeleton").GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        
    }
    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", speed);
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        if(player.transform.position.x > 0f)
        {
            sprite.flipX = false;
        } else {
            sprite.flipX = true;
        }
        
    }

}


