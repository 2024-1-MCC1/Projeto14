using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject plantPreFab;
    public GameObject player;
    float timer = 0;
    public float frequencia = 10;
    public bool taComTerra;
    public bool taComSemente;
    float distancia;
    public float raio = 5;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector3.Distance(transform.position, player.transform.position);
        if(distancia <= raio)
        {
            if(Input.GetKeyDown(KeyCode.T)) 
            {
                taComTerra = true;
            }
            if(Input.GetKeyDown(KeyCode.S)) 
            { 
                taComSemente = true; 
            }
        }

        if (taComTerra && taComSemente)
        {
            GameObject plant = Instantiate(plantPreFab);
            taComTerra = false;
            taComSemente = false;
        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, raio);
    }

}
