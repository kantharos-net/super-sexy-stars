using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Json;

public class Game : MonoBehaviour {

    private Player computer;
    private Player player;
    private Log logBox;

    void Start() {
        List<Card> loadedCardsList = loadCards();
        shuffleCards(loadedCardsList);
        (List<Card> playerCards, List<Card> comCards) = divideCardDeck(loadedCardsList);
        player = new Player("Player1", playerCards);
        computer = new Player("Player2", comCards);
        
    }

    void Update() { 

    }

    List<Card> loadCards() {
        List<Card> loadedCards = new List<Card>();

        StreamReader sr = new StreamReader("../../Config/game-data.json");
        
        return loadedCards;
    }

    void shuffleCards (List<Card> cardList) {
        System.Random rng = new System.Random();
        int n = cardList.Count;
        while (n > 1) {  
            n--;  
            int k = rng.Next(n + 1);
            Card value = cardList[k];
            cardList[k] = cardList[n];
            cardList[n] = value;
        }
    }

    (List<Card>, List<Card>) divideCardDeck(List<Card> cardList) {
        List<Card> hand1 = new List<Card>();
        List<Card> hand2 = new List<Card>();
        int counter = 0;
        foreach(Card card in cardList){
            if (Convert.ToBoolean(counter % 2)){
                hand1.Add(card);
            } else {
                hand2.Add(card);
            }
            counter++;
        }
        return (hand1, hand2);
    }

    Indexes.Players selectStartingPlayer() {
        System.Random rnd = new System.Random();
        return (Indexes.Players) rnd.Next(0,2);
    }

    void gameFlow(){
        
    }
}
