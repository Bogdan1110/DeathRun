using UnityEngine;
public class MoveObject : MonoBehaviour
{
    [SerializeField] private float _speedScenes;
    [SerializeField] private float _deadLine;
    [SerializeField] private float _acceleration = 0;
    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x -_speedScenes, transform.position.y, 0);
        if (gameObject.transform.position.x <= -_deadLine)
        {
            Destroy(gameObject, 1);
        }
    }
}
