using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text game_over_score;
    public GameObject spawn;
    int score = 0;

    int current_score;


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "SCORE:" + score.ToString();
        spawn = GameObject.FindGameObjectWithTag("MainCamera");

        // for the GAME OVER scene score
        game_over_score.text = "SCORE:" + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        current_score = spawn.GetComponent<buildingSpawn>().score;
        scoreText.text = "SCORE:" + current_score.ToString();


        // for the GAME OVER scene score
        game_over_score.text = "SCORE:" + current_score.ToString();

    }
}