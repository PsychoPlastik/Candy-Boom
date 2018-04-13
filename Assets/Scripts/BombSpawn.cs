using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawn : MonoBehaviour {

    public GameObject Bomba;
    public int BombasTotal;
    public int Explosao = 1;
    internal float detonador = 3;
    void Update () {
        //quando apertar de pular. ele coloca bombas
        if (Input.GetButtonDown("Jump") && BombasTotal >= 1)
        {
            //spawnar aonde o personagem estava
            Vector3 spawnPos = new Vector3(Mathf.Round(transform.position.x),0, Mathf.Round(transform.position.z));
            // faz a bomba spawnar
            var novaBomba = Instantiate(Bomba, spawnPos , Quaternion.identity)as GameObject;
            //Pega e cria uma explsão
            novaBomba.GetComponent<Bomb>().Explosao = Explosao;
            novaBomba.GetComponent<Bomb>().detonador = detonador ;
            BombasTotal--;
            //coloca a bomba
            Invoke("AddBomba", detonador);
        }

        if (BombasTotal <= 0)
        {
            BombasTotal++;
        }

    }
    public void AddBomb()
    {
        BombasTotal++;
    }
}

