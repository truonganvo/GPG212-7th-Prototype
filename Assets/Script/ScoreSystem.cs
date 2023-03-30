using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using TMPro;

public class ScoreSystem : NetworkBehaviour
{
    [SerializeField] private NetworkVariable<int> score = new NetworkVariable<int>(0);
    [SerializeField] private NetworkVariable<int> score2 = new NetworkVariable<int>(0);


    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI scoreText2;

    private void Initialise()
    {
        score.Value = 0;
        score2.Value = 0;
    }

    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();
        Initialise();
    }

    void Update()
    {
        scoreText.text = score.Value.ToString();
        scoreText2.text = score2.Value.ToString();
    }

    public void HostScore()
    {
        // Increase the score by 1 on the server
        score.Value++;
    }

    public void ClientScore()
    {
        // Increase the score by 1 on the server
        score2.Value++;
    }
}
