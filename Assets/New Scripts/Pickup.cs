using System;
using Gamekit3D;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Pickup : MonoBehaviour
{
    Damageable damageable;
    SurvivalMod survivalMod;
    
    public int hitPoints = 1;

    public UnityEvent OnResetDamage;
   

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject player = other.gameObject;
            damageable = player.GetComponent<Damageable>();
            damageable.GetHitPoints(hitPoints);
            OnResetDamage.Invoke();
            survivalMod = player.GetComponent<SurvivalMod>();
            survivalMod.ResetTimer();
            Debug.Log("Timer Reset");
            Destroy(gameObject);
        }



    }
    
}

internal class ResetDamage
{
}
