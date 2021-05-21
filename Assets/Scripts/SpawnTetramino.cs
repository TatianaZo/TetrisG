using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTetramino : MonoBehaviour
{
    public GameObject[] tetraminos;

    void Start()
    {
        NewTetramino();
    }

    public void NewTetramino()
    {
       
        Instantiate(tetraminos[Random.Range(0, tetraminos.Length)], transform.position, Quaternion.identity);

    } 
}
