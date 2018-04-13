using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPU : MonoBehaviour {

    public float QuedaMult = 2.5f;
    public float PuloPeq = 10f;
    int pulo = 3;

    Rigidbody rdb;

    private void Awake()
    {
        rdb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (pulo <= 0)
        {
            if (rdb.velocity.y < 0)
            {
                rdb.velocity += Vector3.up * Physics.gravity.y * (QuedaMult - 1) * Time.deltaTime;
            }
            else if (rdb.velocity.y > 0 && !Input.GetKey(KeyCode.I))
            {
                rdb.velocity += Vector3.up * Physics.gravity.y * (PuloPeq - 1) * Time.deltaTime;
                pulo--;
            }
        }
    }



}