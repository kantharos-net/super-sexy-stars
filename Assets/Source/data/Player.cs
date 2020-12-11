using System;
using List;
using UnityEngine;

public class Player : MonoBehaviour {
	private string name { get; set; }
	private List<Card> hand { get; set; }

	public Player(string name, List<Card> hand)
	{
		this.name = name;
		this.hand = hand;
	}
}