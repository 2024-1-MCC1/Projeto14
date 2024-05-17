using UnityEngine;

public class MovimentoBoneco : MonoBehaviour
{
    public float velocidadeNormal = 15f; // Velocidade normal de movimento
    public float velocidadeCorrendo = 25f; // Velocidade quando correndo

    public KeyCode teclaEsquerda = KeyCode.LeftArrow;
    public KeyCode teclaDireita = KeyCode.RightArrow;
    public KeyCode teclaCima = KeyCode.UpArrow;
    public KeyCode teclaBaixo = KeyCode.DownArrow;

    public KeyCode teclaEsquerdaP2 = KeyCode.A;
    public KeyCode teclaDireitaP2 = KeyCode.D;
    public KeyCode teclaCimaP2 = KeyCode.W;
    public KeyCode teclaBaixoP2 = KeyCode.S;

    void Update()
    {
        MovimentoHorizontal();
        MovimentoVertical();
        MovimentoHorizontalP2();
        MovimentoVerticalP2();
    }

    void MovimentoHorizontal()
    {
        float movimentoHorizontal = 0f;

        if (Input.GetKey(teclaEsquerda))
        {
            movimentoHorizontal = -1f;
        }
        else if (Input.GetKey(teclaDireita))
        {
            movimentoHorizontal = 1f;
        }

        float velocidadeAtual = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) ? velocidadeCorrendo : velocidadeNormal;

        Vector3 direcao = new Vector3(movimentoHorizontal, 0f, 0f).normalized;
        transform.position += direcao * velocidadeAtual * Time.deltaTime;

        if (movimentoHorizontal != 0)
        {
            transform.rotation = Quaternion.LookRotation(direcao);
        }
    }

    void MovimentoVertical()
    {
        float movimentoVertical = 0f;

        if (Input.GetKey(teclaBaixo))
        {
            movimentoVertical = -1f;
        }
        else if (Input.GetKey(teclaCima))
        {
            movimentoVertical = 1f;
        }

        float velocidadeAtual = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) ? velocidadeCorrendo : velocidadeNormal;

        Vector3 direcao = new Vector3(0f, 0f, movimentoVertical).normalized;
        transform.position += direcao * velocidadeAtual * Time.deltaTime;

        if (movimentoVertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(direcao);
        }
    }

    void MovimentoHorizontalP2()
    {
        float movimentoHorizontalP2 = 0f;

        if (Input.GetKey(teclaEsquerdaP2))
        {
            movimentoHorizontalP2 = -1f;
        }
        else if (Input.GetKey(teclaDireitaP2))
        {
            movimentoHorizontalP2 = 1f;
        }

        float velocidadeAtual = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) ? velocidadeCorrendo : velocidadeNormal;

        Vector3 direcao = new Vector3(movimentoHorizontalP2, 0f, 0f).normalized;
        transform.position += direcao * velocidadeAtual * Time.deltaTime;

        if (movimentoHorizontalP2 != 0)
        {
            transform.rotation = Quaternion.LookRotation(direcao);
        }
    }

    void MovimentoVerticalP2()
    {
        float movimentoVerticalP2 = 0f;

        if (Input.GetKey(teclaBaixoP2))
        {
            movimentoVerticalP2 = -1f;
        }
        else if (Input.GetKey(teclaCimaP2))
        {
            movimentoVerticalP2 = 1f;
        }

        float velocidadeAtual = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) ? velocidadeCorrendo : velocidadeNormal;

        Vector3 direcao = new Vector3(0f, 0f, movimentoVerticalP2).normalized;
        transform.position += direcao * velocidadeAtual * Time.deltaTime;

        if (movimentoVerticalP2 != 0)
        {
            transform.rotation = Quaternion.LookRotation(direcao);
        }
    }
}
    