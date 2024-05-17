using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tempo : MonoBehaviour
{
    public float tempoMaximo = 10f;
    public float tempoRodada = 10f;
    public TextMeshProUGUI tempoText;
    public TextMeshProUGUI condicaoDeVitoriaText;
    private bool tempoContando = true;
    public bool condicaoDeVitoria;

    public float horaDoEvento;







    // Update is called once per frame
    void Update()
    {
        AtivarEvento();

        float tempoArredondado = Mathf.Round(tempoMaximo);
        if (tempoContando == true)
        {
            tempoMaximo -= Time.deltaTime;
        }

        if (tempoArredondado == 0)
        {
            tempoContando = false;

            if (condicaoDeVitoria == true)
            {
                condicaoDeVitoriaText.text = "Venceu!";
            }
            else
            {
                condicaoDeVitoriaText.text = "Perdeu!";
            }
        }
        tempoText.text = $" 00:{tempoArredondado}";
    }

    void AtivarEvento()
    {
        horaDoEvento = tempoRodada / 2;
        if (tempoMaximo <= horaDoEvento)
        {
            Debug.Log("Evento irá começar");
        }
    }







}