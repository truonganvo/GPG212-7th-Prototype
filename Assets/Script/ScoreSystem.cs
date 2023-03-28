using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using TMPro;

public class ScoreSystem : NetworkBehaviour
{
    public int score = 0; // The current score
    public int score2 = 0; // The current score


    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI scoreText2;

    void Update()
    {
        scoreText.text = score.ToString();
        scoreText2.text = score2.ToString();
    }

    public void HostScore()
    {
        // Increase the score by 1 on the server
        score++;
    }

    public void ClientScore()
    {
        // Increase the score by 1 on the server
        score2++;
    }
}
