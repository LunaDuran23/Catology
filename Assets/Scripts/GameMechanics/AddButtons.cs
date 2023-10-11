using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddButtons : MonoBehaviour
{
    [SerializeField] 
    private Transform puzzleField;

    [SerializeField]
    private GameObject cartaPuzzle;


    private void Awake()
    {
        for (int i = 0; i < 12; i++)
        {
            GameObject puzzle = Instantiate(cartaPuzzle);
            puzzle.name = "Card" + i;
            puzzle.transform.SetParent(puzzleField, false);


        }
    }
}
