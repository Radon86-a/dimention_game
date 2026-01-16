using UnityEngine;

[System.Serializable]
public class Default2dMap
{
    [SerializeField] private int _default_map_seed = 0;
    [SerializeField] private int[] _default_map = new int[49];

    public int default_map_seed => _default_map_seed;
    public int[] default_map => _default_map;
}

[CreateAssetMenu(fileName = "Default2dMapData", menuName = "Scriptable Objects/Default2dMapData")]
public class Default2dMapData : ScriptableObject
{
    [SerializeField] private Default2dMap[] _default_2d_maps;

    public Default2dMap[] default_2d_maps => _default_2d_maps;

    public Default2dMap FindBySeed(int input_map_seed)
    {
        if (_default_2d_maps == null) return null;
        
        foreach (var c in _default_2d_maps)
        {
            if (c.default_map_seed == input_map_seed) return c;
        }
        return null;
    }
}
