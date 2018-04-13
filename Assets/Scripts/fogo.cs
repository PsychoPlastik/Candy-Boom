using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fogo : MonoBehaviour
{

    public GameObject CaixaDest;
    // Use this for initialization
    void Start()
    {
        //tira o fogo quando acabou.
        CaixaDest = GameObject.FindGameObjectWithTag("Destructive");
        Destroy(gameObject, 0.3f);
        
    }
    public void OnTriggerEnter(Collider collision)
    {
        //Não destroi o Fogo de outras explosões,e MATATUTO
        if (collision.gameObject.GetComponent<fogo>() == null)
        {
            Destroy(collision.gameObject);
            return;
        }

        //destroi os objetos na colisão
        if (collision.gameObject.GetComponent<Bomb>() == CaixaDest)
        {
            //Faz com q n mate o power up antes de matar
            Destroy(CaixaDest, 0.3f);
            GetComponent<BoxCollider>().enabled = false;
            
            collision.gameObject.GetComponent<PowerUpSpawner>().SpawnPowerUps();
        }

        //Se achar uma bomba destroi a bomba
        else if (collision.gameObject.GetComponent<Bomb>() != null)
        {
            collision.gameObject.GetComponent<Bomb>().Explode();
        }

        //Destroi oq colidir junto
        Destroy(collision.gameObject);
    }
}
