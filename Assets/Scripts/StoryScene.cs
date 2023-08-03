using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewStoryScene", menuName = "Data/New Story Scene")]
[System.Serializable]

public class StoryScene : GameScene
{
    public List<Sentance> sentences;
    public Sprite background;
    public GameScene nextScene;

    [System.Serializable]

    public struct Sentance
    {
        public string text;
        public Speaker speaker;
    }
}

public class GameScene : ScriptableObject
{

}
