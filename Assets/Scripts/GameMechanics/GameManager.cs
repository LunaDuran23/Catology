using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<Button> buttons = new List<Button>();
    // si creamos que tenga varios niveles este awake se vuelve start y en el awake agregamos las cartas
    void Awake()
    {
        GetButtonCards();
    }

    private void GetButtonCards()
    {
        GameObject[] cardsButtons = GameObject.FindGameObjectsWithTag("PuzzleButton");

        for (int i = 0; i < cardsButtons.Length; i++)
        {
            buttons.Add(cardsButtons[i].GetComponent<Button>());
        }
    }
}
