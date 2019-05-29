using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{

    public GameObject platformPrefab;
    public Transform generationPoint;
    public float distance = 0;
    [SerializeField]
    private float platformWidth;

    // Start is called before the first frame update
    void Start()
    {
        platformWidth = platformPrefab.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector2(transform.position.x + platformWidth + distance, transform.position.y);
            Instantiate(platformPrefab, transform.position, transform.rotation);
        }
    }
}
