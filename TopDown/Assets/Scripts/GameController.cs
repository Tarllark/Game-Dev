using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    [SerializeField]
    private int goal;
    private Vector2[] keyPlacement = { new Vector2(1.3f, 3.2f), new Vector2(-2.1f, -2.25f), new Vector2(-4.5f, 0), new Vector2(2.7f, 3.9f) };
    public GameObject keyPrefab;

    private void Start()
    {
        setGoal();
        for(int i = 0; i < goal; i++)
        {
            Instantiate(keyPrefab, keyPlacement[i], Quaternion.identity);
        }
        Debug.Log(goal);
    }

    private void setGoal()
    {
        Debug.Log(goal = Random.Range(0, 4) + 1);
    }

    public int getGoal()
    {
        return goal;
    }


}
