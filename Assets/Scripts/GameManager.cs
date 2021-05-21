using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject panelLost;
  


    public Text scoreText;
    private int score = 0;
    public float fallTime = 0.8f;
    public Text lvlText;
    private int lvl = 0;

    void Start()
    {

    }


    void Update()
    {

    }

    public void AddScore()
    {
        score += 100;
        scoreText.text = score.ToString();

    }
    public void AddLvl()
    {
        lvl += 1;
        lvlText.text = lvl.ToString();
    }

    public void IncreaseSpeed()
    {
        switch (score)
        {
            case 300:
                fallTime = 0.7f;
                AddLvl();
                break;
            case 600:
                fallTime = 0.6f;
                AddLvl();
                break;
            case 900:
                fallTime = 0.5f;
                AddLvl();
                break;
            case 3000:
                fallTime = 0.4f;
                AddLvl();
                break;
            case 4000:
                fallTime = 0.3f;
                AddLvl();
                break;
            case 4500:
                fallTime = 0.2f;
                AddLvl();
                break;
            case 5500:
                fallTime = 0.1f;
                AddLvl();
                break;
        }

    }
   /* void PlayerLoose()
    {
       
        {
            //if ()
                panelLost.SetActive(true);
        }
        
    }*/

    public void GameOver()
    {
        FindObjectOfType<SpawnTetramino>().enabled = false;
        FindObjectOfType<TetrisBlock>().enabled = false;
        panelLost.SetActive(true);
    }

}