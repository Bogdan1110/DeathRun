using UnityEngine;
using UnityEngine.SceneManagement;

public class FailScene : MonoBehaviour
{
    public void RetrySceneButton(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void MenuSceneButton(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
