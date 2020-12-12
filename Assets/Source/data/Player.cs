using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private string playerName { get; set; }
	private List<Card> playerHand { get; set; }

	public Player(string name, List<Card> hand)
	{
		this.playerName = name;
		this.playerHand = hand;
	}
}