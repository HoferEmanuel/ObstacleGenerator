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


    }

    void GenerateRandomObstacle()
    {
        SetNextGenerationDistance();
    }

    void SetNextGenerationDistance() => nextGenerationDistance = Random.Range(nextGenerationDistanceRange.x, nextGenerationDistanceRange.y);
}