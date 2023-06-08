using System.Security.Cryptography;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    [Header("生成間隔"), Range(0, 10)]
    public float interval = 3.5f;
    [Header("怪物預製物")]
    public GameObject prefabEnemy;
	
	private void SpawnEnemy()
	{
        Instantiate(prefabEnemy, transform.position, transform.rotation);
	}
    
    private void Awake()
	{
        // Spawenemy();

        InvokeRepeating("SpawnEnemy", 0, interval);
	}
}
