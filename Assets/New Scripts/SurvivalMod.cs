using UnityEngine;
using Gamekit3D;

public class SurvivalMod : MonoBehaviour
{
    [SerializeField] private float time = 10f;

    private float timer = 0f;
    Damageable damageable;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        damageable = gameObject.GetComponent<Damageable>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= time)
            { 
                DealDmg();
                timer = 0f;
            }
    }
    
    void DealDmg()
    {
        Damageable.DamageMessage hunger = new Damageable.DamageMessage()
        {
            amount = 1,
            damager = this,
            direction = Vector3.zero,
            damageSource = Vector3.zero,
            throwing = false,
            stopCamera = false,
        };
        damageable.ApplyDamage(hunger);
    }
}
