using Assets.Scripts.PlayerScripts.Support;
using UnityEngine;

namespace Assets.Scripts.PlayerScripts.Attacks.BasicAttack
{
    public class BasicAttack : AttackTemplate
    {
        public GameObject Test;
        public int Radius;
        public float Damage;

        public override void Attack(GameObject player, Vector3 mousePosition)
        {
            var createdObject = Instantiate(Test, mousePosition, Quaternion.identity);
            createdObject.GetComponent<BasicAttackCollision>().InitializeValues(Damage, Radius);
            createdObject.GetComponent<SphereCollider>().enabled = true;
        }
    }
}
