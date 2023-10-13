using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

public class GameManager : MonoBehaviour
{
    public Card[] selectedCards = new Card[2];
    public int tries;
    private int totalCards = 1;




    public void CheckMatch(Card card)
    {
        // first card selected
        if (selectedCards[0] == null)
        {
            Debug.Log("si entro");
            selectedCards[0] = card;
        }

        //second card selected
        else
        {
            tries ++;
            selectedCards[1] = card;

            if(selectedCards[0].cardID == selectedCards[1].cardID)
            {
                Matched();
            }
            else
            {
                NotMatched();
            }

            //empty list
            selectedCards[0] = null;
            selectedCards[1] = null;

        }
    }
   
    private void Matched()
    {
        selectedCards[0].DestroyCard();
        selectedCards[1].DestroyCard();
        totalCards--;

        if (totalCards == 0)
        {
            GameEnd();
        }
    }

    private void NotMatched()
    {
        selectedCards[0].TurnCard();
        selectedCards[1].TurnCard();
    }

    void GameEnd()
    {
        Debug.Log("Game has ended, number of tries: " + tries);
    }

    //crear una nueva funcion para inicializar el numero total de cartas si hacemos mas niveles

}
