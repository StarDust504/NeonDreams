using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewMiniGameScene", menuName = "Data/New Minigame Scene")]
public class CircuitScene : ScriptableObject
{
    public int row;
    public int col;
    public List<int> Data;
}
