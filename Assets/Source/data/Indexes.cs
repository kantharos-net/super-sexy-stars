using UnityEngine;

public class Indexes {
    
    public enum Scene{
        INITIAL,
        RULES,
        COPYRIGHT,
        GAME,
        GAMEOVER
    }

    public enum Attributes{
        SUPER_TRUNFO,
        BREAST_SIZE,
        BOOTY_SIZE,
        CAREER_TIME,
        PERFORMER_CREDITS,
        KINKINESS
    }

    public enum Players{
        NONE,
        PLAYER,
        COM
    }

    public enum RoundResult{
        PLAYER,
        DRAW
    }

    public Scene describeScene { get; set; }
}