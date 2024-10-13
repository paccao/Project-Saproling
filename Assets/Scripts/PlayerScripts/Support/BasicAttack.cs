using UnityEngine;

namespace Assets.Scripts.PlayerScripts.Support
{
    public class BasicAttack : AttackTemplate
    {
        public GameObject Test;
        public int Radius;




        public override void Attack(GameObject player, Vector3 mousePosition)
        {
            var createdObject = Instantiate(Test, mousePosition, Quaternion.identity);
            createdObject.transform.localScale = new Vector3(1,1,1) * Radius;
        }
    }
}