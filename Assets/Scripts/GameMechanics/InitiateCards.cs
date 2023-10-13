using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

public class InitiateCards : MonoBehaviour
{
    //public GameObject[] fronts;
    public GameObject cardPrefab;
    List<SpecificCard> ListofCards = new List<SpecificCard>();
    public float SpacePosition =100000;


    class SpecificCard
    {
        public int ID;
        //public GameObject gatito;
        public SpecificCard(int id) //, GameObject cat)
        {
            ID = id;
            //gatito = cat;

        }
    }

    private void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            ListofCards.Add(new SpecificCard(i));//, fronts[i]));
            ListofCards.Add(new SpecificCard(i)); //, fronts[i]));
        }

        ShuffleCards();
    }


    private void ShuffleCards()
    {
        int totalCards = ListofCards.Count;
        // temporal list for storing te newly arragend cards
        List<SpecificCard> cardList = new List<SpecificCard>();
        for (int i = 0; i < totalCards; i++)
        {
            int ranPosition = Random.Range(0, totalCards-i);
            cardList.Add(ListofCards[ranPosition]);
            ListofCards.RemoveAt(ranPosition);
        }

        ListofCards = cardList;
        SpawnCards();
    }

    private void SpawnCards()
    {
        int columns = 2;
        int rows =  ListofCards.Count / columns;
        
        for (int i = 0;i < ListofCards.Count; i++)
        {
            GameObject thisCard = Instantiate(cardPrefab, new Vector3((i % rows
                + (i % rows * SpacePosition)) - (rows / 5f) + 
                SpacePosition, 1.3f, (i / rows + (i / rows * SpacePosition)) 
                - (columns / 5f) + SpacePosition), cardPrefab.transform.rotation) as GameObject;
            //thisCard.GetComponent<Card>().SetCardNumber( ListofCards[i].ID ); // aca agregaria un nuevo atributo para el gatito
        }

    }

}
