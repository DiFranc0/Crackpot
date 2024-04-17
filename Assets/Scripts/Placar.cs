using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Placar : MonoBehaviour
{
    public TextMeshProUGUI txtPontos;
    public TextMeshProUGUI txtVidas;
    public static int pontos;
    public static int highscore;
    public static int vidas;

    void Start()
    {
        pontos = 0;
        highscore = 0;
        vidas = 3;
        highscore = PlayerPrefs.GetInt("highscore", 0);
    }

    void Update()
    {
        txtPontos.SetText(pontos.ToString("00000"));
        txtVidas.SetText(vidas.ToString("X 00"));
        AddHighscore();

        if (vidas == 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        
    }

    public void AddHighscore()
    {
        if (Placar.highscore < Placar.pontos)
        {
            PlayerPrefs.SetInt("highscore", Placar.pontos);
        }

    }
}
