using UnityEngine;

public class Card : MonoBehaviour {
	public string title { get; set; }
	public string rank { get; set; }
	public int position { get; set; }
	public string imagePath { get; set; }
	public bool isSuperTrunfo { get; set; }
	public char breastSizeCup { get; set; }
	public int breastSizeBand { get; set; }
	public int bootySize { get; set; }
	public int careerTime { get; set; }
	public int performerCredits { get; set; }
	public double kinkiness { get; set; }

	public Card()
	{
		this.title = title;
		this.rank = rank;
		this.position = position;
		this.imagePath = imagePath;
		this.isSuperTrunfo = isSuperTrunfo;
		this.breastSizeCup = breastSizeCup;
		this.breastSizeBand = breastSizeBand;
		this.bootySize = bootySize;
		this.careerTime = careerTime;
		this.performerCredits = performerCredits;
		this.kinkiness = kinkiness;
	}
}