using System.Linq.Expressions;
using System;
using UnityEngine;
using Indexes;

public class Round : MonoBehaviour {
	private Card playerCard;
    private Card comCard;
    private Indexes.Players currentPlayer;

	public Round(Card playerCard, Card ComCard, Indexes.Players currentPlayer)
	{
		this.playerCard = playerCard;
        this.comCard = comCard;
        this.currentPlayer = currentPlayer;
	}

    (Indexes.RoundResult, Indexes.Players) attributeComparison(Indexes.Attributes selectedAttribute) {
        switch (selectedAttribute)
        {
            case GameIndexes.Attributes.SUPER_TRUNFO:
                (Indexes.RoundResult result, Indexes.Players winner) = comparisonSuperTrunfo();
                break;
            case GameIndexes.Attributes.BREAST_SIZE:
                (Indexes.RoundResult result, Indexes.Players winner) = comparisonBreastSize();
                break;
            case GameIndexes.Attributes.BOOTY_SIZE:
                (Indexes.RoundResult result, Indexes.Players winner) = comparisonBootySize();
                break;
            case GameIndexes.Attributes.CAREER_TIME:
                (Indexes.RoundResult result, Indexes.Players winner) = comparisonCareerTime();
                break;
            case GameIndexes.Attributes.PERFORMER_CREDITS:
                (Indexes.RoundResult result, Indexes.Players winner) = comparisonPerformerCredits();
                break;
            case GameIndexes.Attributes.KINKINESS:
                (Indexes.RoundResult result, Indexes.Players winner) = comparisonKinkiness();
                break;
        }
        return (result, winner);
    }

    (Indexes.RoundResult, Indexes.Players) comparisonSuperTrunfo() {
        Indexes.RoundResult result;
        Indexes.Players winner;
        if(this.currentPlayer == Indexes.Players.COM) {
            if(this.playerCard.GetRank() == "A") {
                winner = Indexes.Players.PLAYER;
                result = Indexes.RoundResult.PLAYER;
            } else {
                winner = Indexes.Players.COM;
                result = Indexes.RoundResult.PLAYER;
            }
        }
        else {
            if(this.comCard.GetRank() == "A") {
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
        if(this.comCard.GetAttributes().GetBreastSizeCup() > this.playerCard.GetAttributes().GetBreastSizeCup()) {
            winner = Indexes.Players.COM;
            result = Indexes.RoundResult.PLAYER;
        } else if(this.comCard.GetAttributes().GetBreastSizeCup() < this.playerCard.GetAttributes().GetBreastSizeCup()) {
            winner = Indexes.Players.PLAYER;
            result = Indexes.RoundResult.PLAYER;
        } else {
            if(this.comCard.GetAttributes().GetBreastSizeBand() > this.playerCard.GetAttributes().GetBreastSizeBand()) {
                winner = Indexes.Players.COM;
                result = Indexes.RoundResult.PLAYER;
            } else if(this.comCard.GetAttributes().GetBreastSizeBand() < this.playerCard.GetAttributes().GetBreastSizeBand()) {
                winner = Indexes.Players.PLAYER;
                result = Indexes.RoundResult.PLAYER;
            } else {
                winner = null;
                result = Indexes.RoundResult.DRAW;
            }
        }
        return (result, winner);
    }
    (Indexes.RoundResult, Indexes.Players) comparisonBootySize() {
        Indexes.RoundResult result;
        Indexes.Players winner;
        if(this.comCard.GetAttributes().GetBootySize() > this.playerCard.GetAttributes().GetBootySize()) {
            winner = Indexes.Players.COM;
            result = Indexes.RoundResult.PLAYER;
        } else if(this.comCard.GetAttributes().GetBootySize() < this.playerCard.GetAttributes().GetBootySize()) {
            winner = Indexes.Players.PLAYER;
            result = Indexes.RoundResult.PLAYER;
        } else {
            winner = null;
            result = Indexes.RoundResult.DRAW;
        }
        return (result, winner);
    }
    (Indexes.RoundResult, Indexes.Players) comparisonCareerTime() {
        Indexes.RoundResult result;
        Indexes.Players winner;
        if(this.comCard.GetAttributes().GetCareerTime() > this.playerCard.GetAttributes().GetCareerTime()) {
            winner = Indexes.Players.COM;
            result = Indexes.RoundResult.PLAYER;
        } else if(this.comCard.GetAttributes().GetCareerTime() < this.playerCard.GetAttributes().GetCareerTime()) {
            winner = Indexes.Players.PLAYER;
            result = Indexes.RoundResult.PLAYER;
        } else {
            winner = null;
            result = Indexes.RoundResult.DRAW;
        }
        return (result, winner);
    }
    (Indexes.RoundResult, Indexes.Players) comparisonPerformerCredits() {
        Indexes.RoundResult result;
        Indexes.Players winner;
        if(this.comCard.GetAttributes().GetPerformerCredits() > this.playerCard.GetAttributes().GetPerformerCredits()) {
            winner = Indexes.Players.COM;
            result = Indexes.RoundResult.PLAYER;
        } else if(this.comCard.GetAttributes().GetPerformerCredits() < this.playerCard.GetAttributes().GetPerformerCredits()) {
            winner = Indexes.Players.PLAYER;
            result = Indexes.RoundResult.PLAYER;
        } else {
            winner = null;
            result = Indexes.RoundResult.DRAW;
        }
        return (result, winner);
    }
    (Indexes.RoundResult, Indexes.Players) comparisonKinkiness() {
        Indexes.RoundResult result;
        Indexes.Players winner;
        if(this.comCard.GetAttributes().GetKinkiness() > this.playerCard.GetAttributes().GetKinkiness()) {
            winner = Indexes.Players.COM;
            result = Indexes.RoundResult.PLAYER;
        } else if(this.comCard.GetAttributes().GetKinkiness() < this.playerCard.GetAttributes().GetKinkiness()) {
            winner = Indexes.Players.PLAYER;
            result = Indexes.RoundResult.PLAYER;
        } else {
            winner = null;
            result = Indexes.RoundResult.DRAW;
        }
        return (result, winner);
    }

    
}