using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{

    GameController gc;
    public int BombasTotal;
    public int Explosao;
    public int speed;

    void Start()
    {
        gc = GameObject.Find("ControleDoJogo").GetComponent<GameController>();
        gc.level[(int)transform.position.x, (int)transform.position.z] = gameObject;
    }


    public void OnTriggerEnter(Collider colisao)
    {
        //verifica se ocolisou com o player
        if (colisao.gameObject.tag == "player")
        {

            //ajunta as referencias
            PlayerController playerController = colisao.gameObject.GetComponent<PlayerController>();
            BombSpawn BombSpawnar = colisao.gameObject.GetComponent<BombSpawn>();

            //ajusta os valores.
            playerController.speed += speed;
            BombSpawnar.BombasTotal += BombasTotal;



            //para o jogador não ficar lento demais
            if (playerController.speed <= 3)
            {
                speed = 3;

            }

            //destroi quando for pego
            Destroy(gameObject);
        }
    }

}
