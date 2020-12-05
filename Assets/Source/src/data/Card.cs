using System;

/// <summary>
/// Summary description for Card
/// </summary>
public class Card : MonoBehaviour {
	private string name { get; set; }
	private string rank { get; set; }
	private int position { get; set; }
	private string imagePath { get; set; }
	private bool is_sp { get; set; }
	private CardAttributes attributes { get; set; }

	

	public Card()
	{
		this.name = "";
		this.rank = "";
		this.position = 0;
		this.imagePath = "";
		this.is_sp = false;
		this.attributes = new CardClassAttributes();
	}

	private class CardAttributes {
		private string breastSizeCup { get; set; }
		private int breastSizeBand { get; set; }
		private int bootySize { get; set; }
		private int careerTime { get; set; }
		private int perfCredits { get; set; }
		private float kinkiness { get; set; }

		public CardAttributes() {
			this.breastSizeCup = "";
			this.breastSizeBand = 0;
			this.bootySize = 0;
			this.careerTime = 0;
			this.perfCredits = 0;
			this.kinkiness = 0.0;
		}
	}
	
}