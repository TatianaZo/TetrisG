using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public Sprite red, green;

    void OnMousDown()
    {
        GetComponent<SpriteRenderer>().sprite = green;
    }

    void OnMousUp()
    {
        GetComponent<SpriteRenderer>().sprite = red;
    }

    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "rest":
                Application.LoadLevel(1);
                break;
            case "home":
                Application.LoadLevel("main");
                break;
        }
    }

}
