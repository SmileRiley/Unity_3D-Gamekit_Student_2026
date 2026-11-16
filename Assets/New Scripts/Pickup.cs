using System;
using Gamekit3D;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Pickup : MonoBehaviour
{
    Damageable damageable;
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
            Destroy(gameObject);
        }



    }
    
}

internal class ResetDamage
{
}
