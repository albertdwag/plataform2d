using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 10;
    public string triggerAttack = "Attack";

    public Animator animator;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.transform.name);

        var health = collision.gameObject.GetComponent<HealthBase>();

        if (health != null)
        {
            health.Damage(damage);
            PlayAttackAnimation();
        }
            
    }

    private void PlayAttackAnimation()
    {
        animator.SetTrigger(triggerAttack);
    }
}
