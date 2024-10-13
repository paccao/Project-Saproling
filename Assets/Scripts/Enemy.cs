using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform motherTree;
    [SerializeField] private AnimationCurve curve;
    [SerializeField] private float rotateSpeed = 10f;
    [SerializeField] private float movementSpeed = 2f;
    [SerializeField] private float attackRange = 4f;

    private Vector3 newPosition;

    void FixedUpdate()
    {
        // Enemies stop at their attack range
        if (Vector3.Distance(transform.position, motherTree.position) >= attackRange)
        {
            MoveTowardsMotherTree();
        }
        RotateTowardsMotherTree();
    }

    void RotateTowardsMotherTree()
    {
        // Smoothly rotate towards target
        var targetRotation = Quaternion.LookRotation(motherTree.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);
    }

    void MoveTowardsMotherTree()
    {
        // TODO: fix y position the enemies move towards
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(motherTree.transform.position.x, 1, motherTree.transform.position.z), curve.Evaluate(movementSpeed * Time.deltaTime));
    }
}
