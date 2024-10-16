using UnityEngine;

namespace Assets.Scripts.PlayerScripts.Attacks.BasicAttack
{
    public class BasicAttackCollision : MonoBehaviour
    {
        private float damage;

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Enemy")
            {
                other.gameObject.GetComponent<Enemy>().TakeDamage(damage);
            }
        }

        public void InitializeValues(float attackDamage, float radius)
        {
            damage = attackDamage;
            gameObject.transform.localScale = Vector3.one * radius;
        }
    }
}
