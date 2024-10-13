using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private Transform ground;
    [SerializeField] private GameObject saproling;
    [SerializeField] private float spawnRate;
    [SerializeField] public float spawnHeight = 0.5f;
    private Vector3 topLeft;
    private Vector3 topRight;
    private Vector3 bottomLeft;
    private Vector3 bottomRight;

    private float _time;

    private void Start()
    {
        topLeft = ground.GetChild(0).transform.position;
        topRight = ground.GetChild(1).transform.position;
        bottomLeft = ground.GetChild(2).transform.position;
        bottomRight = ground.GetChild(3).transform.position;
        spawnHeight = ground.transform.position.y;
        _time = 0f;
    }

    private void Update()
    {
        _time += Time.deltaTime;
        while (_time >= spawnRate)
        {
            SpawnEnemy();
            _time -= spawnRate;
        }
    }

    private void SpawnEnemy()
    {
        Vector3 spawnPos;

        // Get random side to spawn at
        int spawnSide = Random.Range(1, 4);

        // Get a random position around the edge of the ground transform
        // TOP
        if (spawnSide == 1)
        {
            spawnPos = new Vector3(Random.Range(topLeft.x, topRight.x), spawnHeight, topRight.z);
        }
        // RIGHT
        else if (spawnSide == 2)
        {
            spawnPos = new Vector3(topRight.x, spawnHeight, Random.Range(topRight.z, bottomRight.z));
        }
        // BOTTOM
        else if (spawnSide == 3)
        {
            spawnPos = new Vector3(Random.Range(bottomRight.x, bottomLeft.x), spawnHeight, bottomRight.z);
        }
        // LEFT
        else
        {
            spawnPos = new Vector3(bottomLeft.x, spawnHeight, Random.Range(bottomLeft.z, topLeft.z));
        }
        // Spawn saproling at that position
        Object.Instantiate(saproling, spawnPos, Quaternion.identity, GameObject.FindWithTag("EnemiesGroup").transform);
    }
}
