using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cubonamao : MonoBehaviour
{
    public Transform planta;
    public GameObject plantaNaMao;
    public Transform player;
    public float raioDaCaptura = 10;

    public bool plantaEstaNaMao = false;

    // Start is called before the first frame update
    void Start()
    {
        plantaNaMao.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (plantaEstaNaMao == true)
        {
            plantaNaMao.SetActive(true);
        }

    }
}
