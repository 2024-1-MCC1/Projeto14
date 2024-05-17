using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerraScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject Mao;
    public GameObject Spawn;
    public SpawnScript spawnScript;
    public float distanciaPlayer;
    public float distanciaSpawn;
    public float raio = 5;
    public bool objetoNaMao;


    private void Awake()
    {
        Mao = GameObject.Find("Mao");
        Spawn = GameObject.Find("Spawn");
        spawnScript = Spawn.GetComponent<SpawnScript>();
        Player = GameObject.FindGameObjectWithTag("Player");

    }
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        distanciaPlayer = Vector3.Distance(transform.position, Player.transform.position);
        if (raio >= distanciaPlayer)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (distanciaSpawn > raio)
                    objetoNaMao = true;
            }
            if (objetoNaMao)
            {
                transform.position = Mao.transform.position;
            }
        }
        distanciaSpawn = Vector3.Distance(transform.position, Spawn.transform.position);
        if (raio >= distanciaSpawn)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (distanciaSpawn < raio)
                    objetoNaMao = false;         
                spawnScript.taComTerra = true;
                if (objetoNaMao == false)
                {
                    Destroy(gameObject);
                }

            }
        }

    }
}