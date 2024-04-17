using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider2 : MonoBehaviour
{
    [SerializeField] bool trigger = false;
    public float frequencia;
    public float magnitude;
    public GameObject[] posJanelas;
    public Vector2[] underJanelas;
    Vector2 embaixoJanela;
    GameObject Janela;
    public float velocidade;
    int index;
    Vector2 posInicial = new Vector2(-3.57f, -3.8f);

    void Start()
    {
        index = Random.Range(0, underJanelas.Length);
        embaixoJanela = underJanelas[index];
        Janela = posJanelas[index];

    }

    // Update is called once per frame
    void Update()
    {
        Movimento();

        if(Placar.pontos > 100f)
        {
            velocidade = 3.5f;
        }

        if (Placar.pontos > 200f)
        {
            velocidade = 4.5f;
        }

        if (Placar.pontos > 300f)
        {
            velocidade = 5.5f;
        }

        if (Placar.pontos > 500f)
        {
            velocidade = 6.5f;
        }

    }

    public void Movimento()
    {
        if (transform.position.y < -3.8f)
        {
            transform.position = Vector2.MoveTowards(transform.position, posInicial, velocidade * Time.deltaTime);
        }

        if (transform.position.y == -3.8f)
        {
            transform.eulerAngles = new Vector3(0f, 0f, -90f);
            if (index == 0)
            {
                transform.eulerAngles = new Vector3(0f, 0f, 90f);
            }

            transform.position = Vector2.MoveTowards(transform.position, embaixoJanela, velocidade * Time.deltaTime);
            if (Vector2.Distance(transform.position, embaixoJanela) == 0.0f)
            {
                transform.eulerAngles = new Vector3(0f, 0f, 0f);
                trigger = true; 
            }

        }

        if (trigger == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, Janela.transform.position, velocidade * Time.deltaTime);
            transform.position = transform.position + transform.right * Mathf.Sin(Time.time * frequencia) * magnitude * Time.deltaTime;
        }
    }

}
