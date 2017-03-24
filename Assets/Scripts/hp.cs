using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hp : MonoBehaviour {

    public float health = 6;
    public Material hitColor;
    public float lagTime;

    private void OnCollisionEnter(Collision col)
    {
        damage component = (damage) col.gameObject.GetComponent<damage>();
        if (component != null)
        {
            health = health - component.getDamage();
            StartCoroutine(hitMarker());

            if (health <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

    private IEnumerator hitMarker()
    {
        Material oldMat=GetComponent<Renderer>().material;
        GetComponent<Renderer>().material = hitColor;
        yield return new WaitForSeconds(lagTime);
        GetComponent<Renderer>().material = oldMat;
    }
}
