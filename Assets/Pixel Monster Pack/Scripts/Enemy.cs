using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject _Player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
         Destroy(_Player);
    }
}
