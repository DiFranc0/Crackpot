using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI ShowScore;
    public TextMeshProUGUI ShowHighscore;
    // Start is called before the first frame update
    void Start()
    {
        ShowScore.text = Placar.pontos.ToString("Your Score: 00000");
        ShowHighscore.text = Placar.highscore.ToString("Highscore: 00000");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    
}
