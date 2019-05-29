using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject PickUpEffect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (other.gameObject.GetComponent <buffs> ().mortal())
            {
                other.gameObject.GetComponent<buffs>().switchMortality();
                effect();
            }

        }
    }

    void effect()
    {
        GameObject activeEffect = Instantiate(PickUpEffect);
        activeEffect.transform.position = gameObject.transform.position;
    }
}
