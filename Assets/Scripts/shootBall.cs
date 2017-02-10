using UnityEngine;
using System.Collections;

public class shootBall : MonoBehaviour
{

    public GameObject projectile;
    public float speed = 20;
    private GameObject clone;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            clone = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
            clone.GetComponent<Rigidbody>().AddForce(clone.transform.forward * speed);
        }
    }
}