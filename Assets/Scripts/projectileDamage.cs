using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileDamage : MonoBehaviour, damage {

    public float damage;

    public void setDamage(float d)
    {
        damage = d;
    }

    public float getDamage() {
        return damage;
    }
}
