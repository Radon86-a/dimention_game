using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "SettingData", menuName = "Scriptable Objects/SettingData")]
public class SettingData : ScriptableObject
{
    [SerializeField] public Key SpaceKey = Key.Space;
}
