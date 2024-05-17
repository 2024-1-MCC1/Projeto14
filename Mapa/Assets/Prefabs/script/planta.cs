using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planta : MonoBehaviour
{
    public cubonamao plantaNaMao;
    public Transform player;
    public float raioDaCaptura = 10;
    public float distancia;

    // Start is called before the first frame update
    void Start()
    {
        //plantaNaMao = GameObject.Find("PlantaNaMao").GetComponent<cubonamao>();
    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector3.Distance(transform.position, player.position);
        if (raioDaCaptura >= distancia)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                plantaNaMao.plantaEstaNaMao = true;
                gameObject.SetActive(false);
            }
        }
    }




}
