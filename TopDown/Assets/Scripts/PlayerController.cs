using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 targetPosition;
    [SerializeField]
    public int score;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Mouse0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * 5);
        }
    }

    public void incrementScore()
    {
        score++;
    }

    public int getScore()
    {
        return score;
    }

}
