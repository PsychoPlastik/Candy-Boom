using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAScalling : MonoBehaviour {
    public float TamTotal;
    public float Crescimento;
    public float Cooldown;

    void Start()
    {
        StartCoroutine(Scale());
    }

    IEnumerator Scale()
    {

        float timer = 0;

        while (true) // this could also be a condition indicating "alive or dead"
        {
            // we scale all axis, so they will have the same value, 
            // so we can work with a float instead of comparing vectors
            while (TamTotal > transform.localScale.x)
            {
                timer += Time.deltaTime;
                transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime * Crescimento;
                yield return null;
            }
            // reset the timer

            yield return new WaitForSeconds(Cooldown);

            timer = 0;
            while (1 < transform.localScale.x)
            {
                timer += Time.deltaTime;
                transform.localScale -= new Vector3(1, 1, 1) * Time.deltaTime * Crescimento;
                yield return null;
            }

            timer = 0;
            yield return new WaitForSeconds(Cooldown);
        }

    }
}

