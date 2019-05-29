using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour
{

    public GameObject destructorPoint;

    private void Start()
    {
        destructorPoint = GameObject.Find("DestructorPoint");
    }

    private void Update()
    {
        if (transform.position.x < destructorPoint.transform.position.x)
            Destroy(gameObject);
    }
}
