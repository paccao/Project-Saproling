using UnityEngine;

public class Player : MonoBehaviour
{
    public float health = 5f;

    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log(health + " health");
        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        // Stop all movement in the game
        // Enable death overlay
        // Disable PlayerAttack
        Debug.Log("Dead");
    }
}
