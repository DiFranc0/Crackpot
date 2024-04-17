using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : MonoBehaviour
{
    [SerializeField] bool triggerActive = false;
    public float velocidade;
    Rigidbody2D rb;
    Vector2 posInicial;
    public SpriteRenderer sr;
    public SpriteRenderer srPumpkin;
    Collider2D co;
    Placar ps;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        co = GetComponent<Collider2D>();
        posInicial = rb.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (triggerActive && Input.GetButtonDown("Jump") && Player.triggerStart)
        {
            rb.velocity = new Vector2(0f, -5f);
        }
    }
        
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        {
            triggerActive = true;
        }

        if(collision.tag == "Spider")
        {
            Destroy(collision.gameObject);
            Placar.pontos+=10;
           
        }

        if(collision.tag == "Floor")
        {
            sr.enabled = false;
            srPumpkin.enabled = false;
            co.enabled = false;
            StartCoroutine(Respawn());
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        {
            triggerActive = false; 
        }
    }

    IEnumerator Respawn()
    {
        rb.position = posInicial;
        rb.velocity = new Vector2(0f, 0f);
        yield return new WaitForSeconds(0.3f);
        sr.enabled = true;
        srPumpkin.enabled = true;
        co.enabled = true;
    }

}

