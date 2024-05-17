using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController CC;
    public float velocidadeDoPlayer = 10;
    Vector3 direcao;
    public float velocidadeDeGiro = 200;
    float smoothTime = 0.05f;
    float currentVelocity;

    public int pontos = 0;
    public TextMeshProUGUI pontosText;

    public GameObject drop;
    public GameObject regador;
    public GameObject semente;
    public GameObject terra;

    private void Awake()
    {
        CC = GetComponent<CharacterController>();
        drop = GameObject.Find("Drop");
        regador = GameObject.Find("Regador");
        semente = GameObject.Find("Semente");
        terra = GameObject.Find("Terra");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimentar();
        Rotacionar();
        pontosText.text = $"{pontos}";
    }
    public void Movimentar()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        direcao = new Vector3(horizontal, 0, vertical);
        CC.Move(direcao * velocidadeDoPlayer * Time.deltaTime);
    }
    public void Rotacionar()
    {
        if (direcao.magnitude >= smoothTime)
        {
            var targetAngle = Mathf.Atan2(direcao.x, direcao.z) * Mathf.Rad2Deg;
            var angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref currentVelocity, smoothTime);
            transform.rotation = Quaternion.Euler(0, angle, 0);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(drop.transform.position, 5);
    }

}
