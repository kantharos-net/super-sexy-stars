using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    private Player computer;
    private Player player;
    private Log logBox;

    void Start() {
        List<Card> loadedCardsList = loadCards();
        shuffleCards(loadedCardsList);
        (List<Card> playerCards, List<Card> comCards) = divideCardDeck(List<Card> loadedCardsList);
        player = new Player("Player1", playerCards);
        computer = new Player("Player2", comCards);

    }

    void Update() { 

    }

    List<Card> loadCards() {
        // Use config file to load the card objects returns a card list
    }

    void shuffleCards (List<Card> cardList) {
        // Shuffles card array
    }

    (List<Card>, List<Card>) divideCardDeck(List<Card> cardList) {
        // Divide deck equally between players
        return (hand1, hand2);
    }

    Indexes.Players selectStartingPlayer() {
        Random rnd = new Random();
        return rnd.next(0,2);
    }

    void gameFlow(){
        
    }
}
