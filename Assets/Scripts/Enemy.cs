using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform motherTree;
    [SerializeField] private AnimationCurve curve;
    [SerializeField] private float movementSpeed = 0.1f;
    [SerializeField] private float _rotateSpeed = 10f;
    private Vector3 newPosition;

    //private void Awake()
    //{
    //    newPosition = transform.localPosition;
    //}

    private void FixedUpdate()
    {
        RotateTowardsMotherTree();
        MoveTowardsMotherTree();
    }

    void RotateTowardsMotherTree()
    {
        // Smoothly rotate towards target
        var targetRotation = Quaternion.LookRotation(motherTree.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, _rotateSpeed * Time.deltaTime);
    }

    void MoveTowardsMotherTree()
    {
        //newPosition.z += 1;
        transform.position = Vector3.MoveTowards(transform.position, motherTree.transform.position, curve.Evaluate(movementSpeed * Time.deltaTime));
    }
}
