using UnityEngine;
using System;

[CreateAssetMenu(fileName = "SceneData", menuName = "Scriptable Objects/SceneData")]
public class SceneData : ScriptableObject
{
    public Action<int> SceneNumberChanged;
    [SerializeField] private int _scene_number;
    [SerializeField] private int _next_scene_number;

    public int scene_number
    {
        get {return _scene_number ;}
        set {_scene_number = value;}
    }
    public int next_scene_number
    {
        get {return _next_scene_number;}
        set {_next_scene_number = value;
        SceneNumberChanged?.Invoke(scene_number);}
    }
}
