using UnityEngine;

public class Player : EntityBase
{
    public float health = 5f;

    public override void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    public override void Die()
    {
        // Stop all movement in the game (stretch goal)
        // Fade in death overlay
        // Disable PlayerAttack (mouse click should be used for menu navigation)
    }
}
