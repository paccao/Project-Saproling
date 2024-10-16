using UnityEngine;

public abstract class EntityBase : MonoBehaviour
{
    public abstract void TakeDamage(float damage);
    public abstract void Die();
}
