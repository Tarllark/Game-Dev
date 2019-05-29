using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform generationPoint;
    public float minDistance;
    public float maxDistance;

    private float distance = 0;
    private float enemyWidth;

    // Start is called before the first frame update
    void Start()
    {
        enemyWidth = enemyPrefab.GetComponent<BoxCollider2D>().size.x;
        if (minDistance <= enemyWidth)
            minDistance = enemyWidth * 1.25f;
    }

    // Update is called once per frame
    void Update()
    {

        distance = Random.Range(minDistance, maxDistance);
        
        if (transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector2(transform.position.x + enemyWidth + distance, transform.position.y);
            Instantiate(enemyPrefab, transform.position, transform.rotation);
        }
    }
}
