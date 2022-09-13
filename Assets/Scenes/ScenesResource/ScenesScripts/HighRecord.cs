using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighRecord : MonoBehaviour
{
    [SerializeField] private Text _highScore;
    void Start()
    {
        _highScore.text = "Ваш рекорд: " + PlayerPrefs.GetInt("HighScore");
    }
}
