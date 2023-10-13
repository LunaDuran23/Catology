using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Card : MonoBehaviour
{
    public int cardID;
    private bool isSelected = false;
    public GameManager manager;

    private void Start()
    {
        manager = manager.GetComponent<GameManager>();
    }

    public void SetCardNumber(int ID)
    {
        cardID = ID;
        // importar el gatito
    }
 
    // Animation for showing front card
    public void ShowCard()
    {
        if (!isSelected)
        {
            isSelected = true;
            GetComponent<Animation>().Play("Flip_show");
            manager.CheckMatch(this);
        }
    }

    //animation for showing back card and unselecting
    public void TurnCard()
    {
        GetComponent<Animation>().Play("Flip_back");
        isSelected = false;
    }

    //corrutine and animation for disapearing card when mached
    public void DestroyCard()
    {
        //animation of card coming foward 
        StartCoroutine("DisolveCard");
    }

    IEnumerator DisolveCard()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
