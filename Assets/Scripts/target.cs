using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour {

    public AudioClip toPlay;
    public float lagTime;

    private int hitcounter=0;

	// Use this for initialization
	void Start () {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = toPlay;
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "bullet")
        {
            hitcounter++;
            StartCoroutine(playSound());
        }
    }

    private IEnumerator playSound()
    {
        for (int i = 0; i < hitcounter; i++)
        {
            print("hit " + (i + 1) + " " + hitcounter + " total hits");
            GetComponent<AudioSource>().Play();
            yield return new WaitForSeconds(lagTime);
        }
    }
}
