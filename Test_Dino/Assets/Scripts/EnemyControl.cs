using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyControl : MonoBehaviour
{
    public int health = 3;
    public Text healthText;

    private EnemyControl enemyControl;
    private Animator animatorEnemy;


    private void Update()
    {
        if(health <= 0)
        {
            Die();
            healthText.text = "";
        }
        else
        {
            healthText.text = health.ToString();
        }
    }

    void Start()
    {
        enemyControl = GetComponent<EnemyControl>();
        animatorEnemy = GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            health -= 1;
        }
    }

    void Die()
    {
        animatorEnemy.SetBool("isDead", true);
        ManagerScript.score += 1;
        enemyControl.enabled = false;
        
    }
}