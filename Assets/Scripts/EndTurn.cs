using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurn : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject PlayerHand;
    public GameObject EnemyHand;
    private List<GameObject> deck = new List<GameObject>();

    void Start()
    {
        deck.Add(Card1);
        deck.Add(Card2);
    }

    public void OnClick()
    {
        GameObject playerCard = Instantiate(deck[Random.Range(0, deck.Count)], new Vector3(0, 0, 0), Quaternion.identity);
        playerCard.transform.SetParent(PlayerHand.transform, false);
    }
}