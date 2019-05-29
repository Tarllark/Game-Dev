using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Movement player;

    private Vector3 playerLocation;

    private float moveBy;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Movement>();
        playerLocation = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        moveBy = player.transform.position.x - playerLocation.x;

        transform.position = new Vector3(transform.position.x + moveBy, transform.position.y, transform.position.z);

        playerLocation = player.transform.position;
    }
}
