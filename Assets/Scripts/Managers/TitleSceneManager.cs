using UnityEngine;

public class TitleSceneManager : MonoBehaviour
{
    [SerializeField] private SceneData sceneData;
    [SerializeField] private InputData inputData;
    void Start()
    {
        
    }

    private void OnEnable()
    {
        // イベントにメソッドを登録
        inputData.KeyInputed += GoSceneChange;
    }

    private void OnDisable()
    {
        // オブジェクトが破棄される時に登録を解除（メモリリーク防止）
        inputData.KeyInputed -= GoSceneChange;
    }

    public void GoSceneChange(int NextScene)
    {
        Debug.Log("scenenumberwaschanged");
        sceneData.next_scene_number = 1;
    }
}
