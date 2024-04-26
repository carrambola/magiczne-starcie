using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerHandInitializer : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject PlayerHand;
    public GameObject EnemyHand;
    private List<GameObject> deck = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        deck.Add(Card1);
        deck.Add(Card2);
        for (var i = 0; i < 5; i++)
        {
            GameObject startingCard = Instantiate(deck[Random.Range(0, deck.Count)], new Vector3(0, 0, 0),
                Quaternion.identity);
            startingCard.transform.SetParent(PlayerHand.transform, false);
        }
    }
}