using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buffs : MonoBehaviour
{
    [SerializeField, Tooltip("Is character able to die?")]
    private bool mortality = true;
    [SerializeField, Tooltip("Buff duration time.")]
    public float buffDuration = 30f;

    private float buffUpTime;

    private void Update()
    {
        if (Time.time >= buffUpTime && !mortality)
            switchMortality();
    }

    public void switchMortality()
    {
        buffUpTime = Time.time + buffDuration;
        mortality = !mortality;
    }
    
    public bool mortal()
    {
        return mortality;
    }
}
