using UnityEngine;

[System.Serializable]
public class DefaultCharacter
{
    [SerializeField] private string _default_name = "character_name";
    [SerializeField] private int _default_character_ID = 0;
    [SerializeField] private int _default_element = 0;
    [SerializeField] private int _default_hp = 100;
    [SerializeField] private int _default_mp = 100;
    [SerializeField] private int _default_attack = 10;

    public string default_name => _default_name;
    public int default_character_ID => _default_character_ID;
    public int default_element => _default_element;
    public int default_hp => _default_hp;
    public int default_mp => _default_mp;
    public int default_attack => _default_attack;
}

[CreateAssetMenu(fileName = "DefaultCharacterData", menuName = "Scriptable Objects/DefaultCharacterData")]
public class DefaultCharacterData : ScriptableObject
{
    [SerializeField] private DefaultCharacter[] _default_characters;

    public DefaultCharacter[] default_characters => _default_characters;

    //キャラクターの名前から探すためのコード
    public DefaultCharacter FindByName(string input_name)
    {
        if (_default_characters == null) return null;
        
        foreach (var c in _default_characters)
        {
            if (c.default_name == input_name) return c;
        }
        return null;
    }
    
    //キャラクターのIDから探すためのコード
    public DefaultCharacter FindByID(int input_ID)
    {
        if (_default_characters == null) return null;
        
        foreach (var c in _default_characters)
        {
            if (c.default_character_ID == input_ID) return c;
        }
        return null;
    }
}