using UnityEngine;

public class CreateScenesObject : MonoBehaviour
{
    [SerializeField] public int secondSpawnObject;
    [SerializeField] public int secondSpawnObjectSky;
    [SerializeField] public int secondEnemySpawn;

    [SerializeField] private GameObject[] _objectsBackground;
    //[SerializeField] private GameObject[] _objects;
    [SerializeField] private GameObject[] _objectsSky;
    [SerializeField] private GameObject _background;
    [SerializeField] private GameObject[] _enemy;

    [SerializeField] private GameObject[] _spawnerEnemy;
    [SerializeField] private GameObject[] _spawnerObjectsBackground;
    [SerializeField] private GameObject[] _spawnerObjectsSky;
    [SerializeField] private GameObject _spawnerBackground;
    [SerializeField] private GameObject _floor;
    private void Start()
    {
        InvokeRepeating("CreateFloor", 1, 1);
        InvokeRepeating("ObjectSkyCreate", Random.Range(1, secondSpawnObjectSky), Random.Range(5, 10));
        InvokeRepeating("BackGroundSpawnObject", Random.Range(3, 7), Random.Range(3,7));
        InvokeRepeating("BackGroundSpawn", 1, 30);
        InvokeRepeating("CreateEnemy", Random.Range(1, secondEnemySpawn), Random.Range(5, 10));
    }
    private void CreateEnemy()
    {
        int randomEnemy = Random.Range(0, _enemy.Length);
        int randomEnemySpawner = Random.Range(0, _spawnerEnemy.Length);
        Instantiate(_enemy[randomEnemy], _spawnerEnemy[randomEnemySpawner].transform.position, Quaternion.identity);
    }
    private void CreateFloor()
    {
        Instantiate(_floor, new Vector3(20f, -4f, 0f), Quaternion.identity);
    }

    private void ObjectSkyCreate()
    {
        int randomObject = Random.Range(0, _objectsSky.Length);
        int randomObjectSpawner = Random.Range(0, _spawnerObjectsSky.Length);
        Instantiate(_objectsSky[randomObject], _spawnerObjectsSky[randomObjectSpawner].transform.position, Quaternion.identity);
    }

    private void BackGroundSpawnObject()
    {
        int randomObject = Random.Range(0, _objectsBackground.Length);
        int randomObjectSpawner = Random.Range(0, _spawnerObjectsBackground.Length);
        Instantiate(_objectsBackground[randomObject], _spawnerObjectsBackground[randomObjectSpawner].transform.position, Quaternion.identity);
    }
    private void BackGroundSpawn()
    {
        Instantiate(_background, _spawnerBackground.transform.position, Quaternion.identity);
    }
}
