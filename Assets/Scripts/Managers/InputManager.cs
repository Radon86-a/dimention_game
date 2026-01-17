using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    [SerializeField] private InputData inputData;
    [SerializeField] private SettingData settingData;
    void Update()
    {
        inputData.spaceKey_isPlessed = Keyboard.current[settingData.SpaceKey].wasPressedThisFrame;
        inputData.leftButton_isClicked = Mouse.current.leftButton.wasPressedThisFrame;
        inputData.rightButton_isClicked = Mouse.current.rightButton.wasPressedThisFrame;
            
        
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            
        }
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            
        }
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            
        }
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            
        }
        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            
        }
        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            
        }
        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            
        }
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            
        }
    }
}
