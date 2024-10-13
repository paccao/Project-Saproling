using UnityEngine;

public class Player : MonoBehaviour
{
    public float health = 10f;

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
        // Stop all movement 
        // Enable death overlay
        // Disable PlayerAttack functionality
        Debug.Log("Dead");
    }
}
