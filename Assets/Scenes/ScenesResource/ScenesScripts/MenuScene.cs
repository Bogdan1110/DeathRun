using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MenuScene : MonoBehaviour
{
    [SerializeField] private AudioSource audio;
    [SerializeField] private Toggle toggle;
    public void StartGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void MusicMute()
    {
        audio.mute = !toggle.isOn;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
