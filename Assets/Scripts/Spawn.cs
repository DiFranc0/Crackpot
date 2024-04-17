using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject spiderPrefab;
    public GameObject spiderPrefab2;
    bool geradorAtivado = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit") && geradorAtivado == false)
        {
            StartCoroutine(Gerador());
            StartCoroutine(Gerador2());
            geradorAtivado = true;
        }
    }


    IEnumerator Gerador()
    {
        Instantiate(spiderPrefab, transform.position, transform.rotation);
        yield return new WaitForSeconds(Random.Range(2f, 4f));
        StartCoroutine(Gerador());
    }

    IEnumerator Gerador2()
    {
        yield return new WaitForSeconds(Random.Range(3f, 10f));
        Instantiate(spiderPrefab2, transform.position, transform.rotation);
        StartCoroutine(Gerador2());
    }
}
