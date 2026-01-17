using UnityEngine;
using System;

[CreateAssetMenu(fileName = "InputData", menuName = "Scriptable Objects/InputData")]
public class InputData : ScriptableObject
{
    public Action<int> KeyInputed;

    public bool _spaceKey_isPlessed = false;
    public bool _leftButton_isClicked = false;
    public bool _rightButton_isClicked = false;
    public bool spaceKey_isPlessed
    {
        get {return _spaceKey_isPlessed;}
        set {_spaceKey_isPlessed = value;
        if (_spaceKey_isPlessed == true)
            {
                KeyInputed?.Invoke(0);
            }
        }
    }
    public bool leftButton_isClicked 
    {
        get {return _leftButton_isClicked;}
        set {_leftButton_isClicked = value;
        if (_leftButton_isClicked == true)
            {
                KeyInputed?.Invoke(0);
            }
        }
    }
    public bool rightButton_isClicked 
    {
        get {return _rightButton_isClicked;}
        set {_rightButton_isClicked = value;
        if (_rightButton_isClicked == true)
            {
                KeyInputed?.Invoke(0);
            }
        }
    }
}