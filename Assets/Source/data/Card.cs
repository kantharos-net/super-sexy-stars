using System.Reflection;
using System;
using UnityEngine;

public class Card : MonoBehaviour {
	private string title { get; set; }
	private char rank { get; set; }
	private int position { get; set; }
	private string imagePath { get; set; }
	private bool isSuperTrunfo { get; set; }
	private CardAttributes attributes { get; set; }

	public Card()
	{
		this.title = title;
		this.rank = rank;
		this.position = position;
		this.imagePath = imagePath;
		this.isSuperTrunfo = isSuperTrunfo;
		this.attributes = null;
	}

	public void loadCardAttributes (
		string breastSizeCup,
		int breastSizeBand,
		int bootySize,
		int careerTime,
		int perfCredits,
		double kinkiness
	) {
		this.attributes = new CardAttributes(
			breastSizeCup,
			breastSizeBand,
			bootySize,
			careerTime,
			perfCredits,
			kinkiness
		);
	}

	public class CardAttributes {
		private char breastSizeCup { get; set; }
		private int breastSizeBand { get; set; }
		private int bootySize { get; set; }
		private int careerTime { get; set; }
		private int perfCredits { get; set; }
		private double kinkiness { get; set; }

		public CardAttributes() {
			this.breastSizeCup = breastSizeCup;
			this.breastSizeBand = breastSizeBand;
			this.bootySize = bootySize;
			this.careerTime = careerTime;
			this.perfCredits = perfCredits;
			this.kinkiness = kinkiness;
		}
	}
}