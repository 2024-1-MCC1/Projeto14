using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegadorScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject Mao;
    public Transform Drop;
    public SpawnScript spawnScript;
    public float distanciaPlayer;
    public float distanciaDrop;
    public float raio = 5;
    public bool objetoNaMao;


    private void Awake()
    {
        Mao = GameObject.Find("Mao");
        Drop = GameObject.Find("Drop").transform; 
        spawnScript = Drop.GetComponent<SpawnScript>();
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
                if (distanciaDrop > raio)
                    objetoNaMao = true;
            }
            if (objetoNaMao)
            {
                transform.position = Mao.transform.position;
            }
        }
        distanciaDrop = Vector3.Distance(transform.position, Drop.transform.position);
        if (raio >= distanciaDrop)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (distanciaDrop < raio)
                    objetoNaMao = false;           
                if (objetoNaMao == false)
                {
                    Destroy(gameObject);
                }

            }
        }

    }
}
