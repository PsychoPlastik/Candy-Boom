using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IA : MonoBehaviour
{
    //https://www.youtube.com/watch?v=P9Uscu97ecc

 
    private Rigidbody rdb;
    NavMeshAgent navMeshAgent;
    NavMeshPath caminho;
    public float TimerCaminho = 0.5f;
    bool NaRotina;
    Vector3 Alvo;
    bool caminhoValido;
    public GameObject player;

    void Start()
    {
        rdb = GetComponent<Rigidbody>();
        navMeshAgent = GetComponent<NavMeshAgent>();

    }

    private void Update()
    {
        if (!NaRotina)
            StartCoroutine(SeiLa());

        if (Vector3.Distance(transform.position, player.transform.position) < 1)
        {
            player.SendMessage("getEnemy");
            Destroy(player);
        }

    }


    Vector3 NovaRNGPos()
    {

        float x = Random.Range(-20, 20);
        float z = Random.Range(-20, 20);
        Vector3 pos = new Vector3(x, 0, z);
        return pos;
    }

    IEnumerator SeiLa()
    {
        NaRotina = true;
        yield return new WaitForSeconds(TimerCaminho);
        NovoCaminho();

        while (!caminhoValido)
        {
            NovoCaminho();
            caminhoValido = navMeshAgent.CalculatePath(Alvo, caminho);
        }

        NaRotina = false;
    }

    void NovoCaminho()
    {
        Alvo = NovaRNGPos();
        navMeshAgent.SetDestination(NovaRNGPos());
    }

}