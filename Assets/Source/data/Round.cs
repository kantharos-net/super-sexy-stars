using UnityEngine;

public class Round : MonoBehaviour {
	private Card playerCard;
    private Card comCard;
    private Indexes.Players currentPlayer;

	public Round(Card playerCard, Card comCard, Indexes.Players currentPlayer)
	{
        this.comCard = comCard;
		this.playerCard = playerCard;
        this.currentPlayer = currentPlayer;
	}

    (Indexes.RoundResult, Indexes.Players) attributeComparison(Indexes.Attributes selectedAttribute) {
        Indexes.RoundResult result = 0;
        Indexes.Players winner = 0;
        switch (selectedAttribute)
        {
            case Indexes.Attributes.SUPER_TRUNFO:
                (result, winner) = comparisonSuperTrunfo();
                break;
            case Indexes.Attributes.BREAST_SIZE:
                (result, winner) = comparisonBreastSize();
                break;
            case Indexes.Attributes.BOOTY_SIZE:
                (result, winner) = comparisonBootySize();
                break;
            case Indexes.Attributes.CAREER_TIME:
                (result, winner) = comparisonCareerTime();
                break;
            case Indexes.Attributes.PERFORMER_CREDITS:
                (result, winner) = comparisonPerformerCredits();
                break;
            case Indexes.Attributes.KINKINESS:
                (result, winner) = comparisonKinkiness();
                break;
        }
        return (result, winner);
    }

    (Indexes.RoundResult, Indexes.Players) comparisonSuperTrunfo() {
        Indexes.RoundResult result;
        Indexes.Players winner;

        if(this.currentPlayer == Indexes.Players.COM) {
            if(this.playerCard.rank == "A") {
                winner = Indexes.Players.PLAYER;
                result = Indexes.RoundResult.PLAYER;
            } else {
                winner = Indexes.Players.COM;
                result = Indexes.RoundResult.PLAYER;
            }
        }
        else {
            if(this.comCard.rank == "A") {
                winner = Indexes.Players.COM;
                result = Indexes.RoundResult.PLAYER;
            } else {
                winner = Indexes.Players.PLAYER;
                result = Indexes.RoundResult.PLAYER;
            }
        }
        return (result, winner);
    }
    (Indexes.RoundResult, Indexes.Players) comparisonBreastSize(){
        Indexes.RoundResult result;
        Indexes.Players winner;
        if(this.comCard.breastSizeCup > this.playerCard.breastSizeCup) {
            winner = Indexes.Players.COM;
            result = Indexes.RoundResult.PLAYER;
        } else if(this.comCard.breastSizeCup < this.playerCard.breastSizeCup) {
            winner = Indexes.Players.PLAYER;
            result = Indexes.RoundResult.PLAYER;
        } else {
            if(this.comCard.breastSizeBand > this.playerCard.breastSizeBand) {
                winner = Indexes.Players.COM;
                result = Indexes.RoundResult.PLAYER;
            } else if(this.comCard.breastSizeBand < this.playerCard.breastSizeBand) {
                winner = Indexes.Players.PLAYER;
                result = Indexes.RoundResult.PLAYER;
            } else {
                winner = Indexes.Players.NONE;
                result = Indexes.RoundResult.DRAW;
            }
        }
        return (result, winner);
    }
    (Indexes.RoundResult, Indexes.Players) comparisonBootySize() {
        Indexes.RoundResult result;
        Indexes.Players winner;
        if(this.comCard.bootySize > this.playerCard.bootySize) {
            winner = Indexes.Players.COM;
            result = Indexes.RoundResult.PLAYER;
        } else if(this.comCard.bootySize < this.playerCard.bootySize) {
            winner = Indexes.Players.PLAYER;
            result = Indexes.RoundResult.PLAYER;
        } else {
            winner = Indexes.Players.NONE;
            result = Indexes.RoundResult.DRAW;
        }
        return (result, winner);
    }
    (Indexes.RoundResult, Indexes.Players) comparisonCareerTime() {
        Indexes.RoundResult result;
        Indexes.Players winner;
        if(this.comCard.careerTime > this.playerCard.careerTime) {
            winner = Indexes.Players.COM;
            result = Indexes.RoundResult.PLAYER;
        } else if(this.comCard.careerTime < this.playerCard.careerTime) {
            winner = Indexes.Players.PLAYER;
            result = Indexes.RoundResult.PLAYER;
        } else {
            winner = Indexes.Players.NONE;
            result = Indexes.RoundResult.DRAW;
        }
        return (result, winner);
    }
    (Indexes.RoundResult, Indexes.Players) comparisonPerformerCredits() {
        Indexes.RoundResult result;
        Indexes.Players winner;
        if(this.comCard.performerCredits > this.playerCard.performerCredits) {
            winner = Indexes.Players.COM;
            result = Indexes.RoundResult.PLAYER;
        } else if(this.comCard.performerCredits < this.playerCard.performerCredits) {
            winner = Indexes.Players.PLAYER;
            result = Indexes.RoundResult.PLAYER;
        } else {
            winner = Indexes.Players.NONE;
            result = Indexes.RoundResult.DRAW;
        }
        return (result, winner);
    }
    (Indexes.RoundResult, Indexes.Players) comparisonKinkiness() {
        Indexes.RoundResult result;
        Indexes.Players winner;
        if(this.comCard.kinkiness > this.playerCard.kinkiness) {
            winner = Indexes.Players.COM;
            result = Indexes.RoundResult.PLAYER;
        } else if(this.comCard.kinkiness < this.playerCard.kinkiness) {
            winner = Indexes.Players.PLAYER;
            result = Indexes.RoundResult.PLAYER;
        } else {
            winner = Indexes.Players.NONE;
            result = Indexes.RoundResult.DRAW;
        }
        return (result, winner);
    }

    
}