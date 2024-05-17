using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


public class planta2 : MonoBehaviour
{
    
    public GameObject Player;
    public PlayerController PlayerScript;
    public GameObject mao;
    public Transform Drop;
    public float raioDaCaptura = 10;
    public float distanciaPlantaPlayer;
    public float distanciaPlantaDrop;
    public bool cuboEstaNaMao;
    public bool cuboEstaNoDrop;
    public bool taComRegador;
    float timer = 0;
    float tempoDaPlanta = 5;

    public bool taRegada;

    public void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        mao = GameObject.Find("Mao");
        PlayerScript = Player.GetComponent<PlayerController>();
        Drop = GameObject.Find("Drop").transform;
    }
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        distanciaPlantaPlayer = Vector3.Distance(transform.position, Player.transform.position);
        if (raioDaCaptura >= distanciaPlantaPlayer)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                cuboEstaNaMao = true;
            }
            if(cuboEstaNaMao)
            {
                transform.position = mao.transform.position;
            }

            distanciaPlantaDrop = Vector3.Distance(transform.position, Drop.transform.position);
            if(raioDaCaptura >= distanciaPlantaDrop && transform.position == mao.transform.position)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    cuboEstaNaMao = false;
                    cuboEstaNoDrop = true; 
                }
            }
            if (cuboEstaNoDrop)
            {
                transform.position = Drop.transform.position;
            }

            if(transform.position == Drop.transform.position)
            {
                if (Input.GetKeyDown(KeyCode.R))
                {
                    taRegada = true;
                }
                if (taRegada)
                { 
                    if (timer >= tempoDaPlanta)
                    {
                        Destroy(gameObject);
                        PlayerScript.pontos++;
                        timer = 0;
                    }
                    timer += Time.deltaTime;
                }

            }
            
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, raioDaCaptura);
        

    }
    
}
