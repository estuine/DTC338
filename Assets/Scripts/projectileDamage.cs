using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileDamage : MonoBehaviour, damage {

    public float damage;
    public AudioClip hit;

    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = hit;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().Play();
    }

    public void setDamage(float d)
    {
        damage = d;
    }

    public float getDamage() {
        return damage;
    }
}
