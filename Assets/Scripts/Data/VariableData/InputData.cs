using UnityEngine;

[CreateAssetMenu(fileName = "InputData", menuName = "Scriptable Objects/InputData")]
public class InputData : ScriptableObject
{
    public bool spaceKey_isPlessed { get; set; }
    public bool leftButton_isClicked { get; set; }
    public bool rightButton_isClicked { get; set; }
}