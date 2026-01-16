using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private SceneData sceneData;
    [SerializeField] private InputData inputData;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        sceneData.scene_number = 0;
        // イベントにメソッドを登録
        sceneData.SceneNumberChanged += SceneChange;
    } 

    // SOから呼び出されるメソッド
    private void SceneChange(int newSceneNumber)
    {
        SceneManager.LoadScene(sceneData.next_scene_number);
    }
}
