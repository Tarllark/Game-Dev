using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    [SerializeField, Tooltip("GameController object")]
    public GameObject GC;
    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        int goal = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().getGoal();
        int score = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().getScore();
        
        if (other.tag == "Player" && (goal == score))
        {
            SceneManager.LoadScene("Menu");
            Debug.Log("You win!");
        }
    }
}
