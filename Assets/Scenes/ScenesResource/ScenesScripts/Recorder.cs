using UnityEngine.UI;
using UnityEngine;

public class Recorder : MonoBehaviour
{
    [SerializeField] private Text Text;
    [SerializeField] public int _record = 0;
    [SerializeField] private int _highRecord;
    private void Start()
    {
        _highRecord = PlayerPrefs.GetInt("HighScore");
    }
    private void FixedUpdate()
    {
        Text.text = "Пробег: " + _record++ + " " +
            "Максимальный пробег: " + _highRecord;
    }
}
