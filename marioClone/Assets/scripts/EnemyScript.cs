using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && other.gameObject.GetComponent<buffs>().mortal())
        {
            Debug.Log(other.gameObject.GetComponent<buffs>().mortal());
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }
}
