using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    private float randomX;
    Vector2 whereToSpawn;
    float nextSpawn = 0.0f;
    
    void Update()
    {
        if (Time.time >= nextSpawn) 
        {
            nextSpawn = Time.time + Random.Range(0.1f, 2.4f);
            randomX = Random.Range(-9, 7);
            whereToSpawn = new Vector2(randomX, transform.position.y);
            GameObject Enemy = Instantiate(obj, whereToSpawn, Quaternion.identity);
            Destroy(Enemy, 1.7f);
        }
    }
}
