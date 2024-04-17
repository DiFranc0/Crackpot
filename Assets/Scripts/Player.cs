using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade;
    public Animator animator;
    public static bool triggerStart; 
    
    // Start is called before the first frame update
    void Start()
    {
        triggerStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        float px = Input.GetAxisRaw("Horizontal") * velocidade * Time.deltaTime;

        if (Input.GetButtonDown("Submit"))
        {
            triggerStart = true;
            
        }
        if (triggerStart)
        {
            transform.Translate(px, 0f, 0f);
            animator.SetFloat("Speed", px);
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Limite")
        {
         transform.position = new Vector2(transform.position.x * -1, transform.position.y);
        }
    }
    

}
