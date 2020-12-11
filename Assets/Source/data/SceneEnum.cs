using UnityEngine;

public class SceneIndex {
    
    public enum Scene{
        INITIAL,
        RULES,
        COPYRIGHT,
        GAME
    }

    public Scene describeScene { get; set; }
}