using UnityEngine;

namespace Assets.Scripts.PlayerScripts.Support
{
    public abstract class AttackTemplate : MonoBehaviour
    {
        public abstract void Attack(GameObject player, Vector3 mousePosition);
    }
}