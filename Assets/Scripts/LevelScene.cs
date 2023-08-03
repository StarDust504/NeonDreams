using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewLevelScene", menuName = "Data/New Level Scene")]
[System.Serializable]
public class LevelScene : GameScene
{
    public Sprite background;
    public string chapterNumber;
    public string text;
    public GameScene nextScene;
}
