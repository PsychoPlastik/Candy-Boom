using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject fogo;
    public int Explosao;
    internal float detonador;
    GameController gc;

    Vector3[] directions = new Vector3[] {
    Vector3.forward,
    Vector3.back,
    Vector3.left,
    Vector3.right
    };

    void Start()
    {
        Invoke("Explode", detonador);
        gc = GameObject.Find("ControleDoJogo").GetComponent<GameController>();
    }

    //Bomba explodir
    public void Explode()
    {

        //Previni ter 2 explsões
        CancelInvoke("Explode");

        //cria o fogo do meio
        Instantiate(fogo, transform.position, Quaternion.identity);

        //cria o resto do foto
        foreach (var direction in directions)
        {
            Spawnfogo(direction);
        }
        Destroy(gameObject);
    }

    private void Spawnfogo(Vector3 offset, int fogo = 1)
    {
        //Calcula a Posição do Fogo
        int x = (int)transform.position.x + (int)offset.x * fogo;
        int z = (int)transform.position.z + (int)offset.z * fogo;

        x = Mathf.Clamp(x, 0, GameController.X - 1);
        z = Mathf.Clamp(z, 0, GameController.Z - 1);

        //se o espaço está vazio.
            if (gc.level[x,z] == null && fogo < Explosao)
        {
            Instantiate(this.fogo, transform.position + (offset * fogo), Quaternion.identity);

            //altura do fogo, faz o fogo spawnar
            Spawnfogo(offset, ++fogo);
        }
        else if(fogo < Explosao)
        {
            //Olha se acertou algo
            if (gc.level[x, z] != null && gc.level[x, z].tag == "Destroyable")
            {
                Instantiate(this.fogo, transform.position + (offset * fogo), Quaternion.identity);
            }
        }
    }
    public void OnTriggerExit(Collider colisao)
    {
        //Se a bomba collide com algo
        GetComponent<Collider>().isTrigger = false;
    }
}
