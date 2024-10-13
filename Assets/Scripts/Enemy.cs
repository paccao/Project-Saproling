using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private AnimationCurve curve;
    [SerializeField] private GameObject enemyAttack;
    [SerializeField] private float rotateSpeed = 10f;
    [SerializeField] private float movementSpeed = 2f;
    [SerializeField] private float attackRange = 4f;
    [SerializeField] private float attackSpeed = 3f;
    [SerializeField] private float attackDamage = 1f;

    private Vector3 newPosition;
    private float attackTime = 0f;

    void FixedUpdate()
    {
        RotateTowardsPlayer();

        if (Vector3.Distance(transform.position, player.position) >= attackRange)
        {
            MoveTowardsPlayer();
        } else
        {
            attackTime += Time.deltaTime;
            while (attackTime >= attackSpeed)
            {
                Attack();
                attackTime -= attackSpeed;
            }
        }
    }

    void RotateTowardsPlayer()
    {
        // Smoothly rotate towards target
        var targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);
    }

    void MoveTowardsPlayer()
    {
        // TODO: fix y position the enemies move towards
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, 1, player.transform.position.z), curve.Evaluate(movementSpeed * Time.deltaTime));
    }

    void Attack()
    {
        GameObject.Instantiate(enemyAttack, new Vector3(transform.position.x, transform.localPosition.y + 1.5f, transform.position.z), Quaternion.identity);
        GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().TakeDamage(attackDamage);
    }
}
