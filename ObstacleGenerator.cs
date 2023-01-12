using System.Collection.Generics;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public static ObstacleGenerator current;

    public Transform followTrans;

    public Vector3 lastGenerationPos;
    public Vector2 nextGenerationDistanceRange;
    public float nextGenerationDistance;

    private void Awake()
    {
        current = this;

        SetNextGenerationDistance();
    }

    private void Update()
    {
        FollowTrans();
        CheckGenerationDistance();
    }

    void FollowTrans()
    {
        if (follow == null) return;

        transform.position = followTrans.position;
        transform.rotation = followTrans.rotation;
    }

    void CheckGenerationDistance()
    {
        if (follow == null) return;

        if (transform.position.z > lastGenerationPos.z + nextGenerationDistance || transform.position.z < lastGenerationPos.z - nextGenerationDistance)
            GenerateRandomObstacle();
        if (transform.position.y > lastGenerationPos.y + nextGenerationDistance || transform.position.y < lastGenerationPos.y - nextGenerationDistance)
            GenerateRandomObstacle();
        if (transform.position.x > lastGenerationPos.x + nextGenerationDistance || transform.position.x < lastGenerationPos.x - nextGenerationDistance)
            GenerateRandomObstacle();
    }

    void GenerateRandomObstacle()
    {
        SetNextGenerationDistance();
    }

    void SetNextGenerationDistance() => nextGenerationDistance = Random.Range(nextGenerationDistanceRange.x, nextGenerationDistanceRange.y);

    void SetLastGenerationDistance() => lastGenerationPos = transform.position;
}