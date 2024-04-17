using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PressStart : MonoBehaviour
{
    public TextMeshProUGUI enter;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.triggerStart)
        {
            enter.enabled = false;
            animator.enabled = false;
        }
    }
}
