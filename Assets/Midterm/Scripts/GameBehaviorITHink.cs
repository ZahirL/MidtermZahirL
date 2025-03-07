using UnityEngine;

public class GameBehaviorITHink : MonoBehaviour
{
    public GameObject Hazard;
    public GameObject coin;
    public GameObject player;
    public Vector2 coinSpawnRate = new Vector2(2f, 3f);

    public float maxSpawnRate = 3f;
    public float minSpawnRate = 1f;
    public float timeForMaxSpawn = 60f;
    public float cameraX = 10;
    public float cameraY = 5;
    public float angleOffset = 20f;

    float timer = 0;
    float spawnTimer;
    float coinTimer = 0;
    float scale = 1f;
    float scaleGrowth = 5f;
    float scaleShrink = 3f;




    private void Update()
    {
        timer += Time.deltaTime;
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0)
        {
            SpawnHazard();

            float calculatedSpawnRate = Mathf.Lerp(maxSpawnRate, minSpawnRate, timer / timeForMaxSpawn);
            spawnTimer = calculatedSpawnRate;
        }

        coinTimer -= Time.deltaTime;
        if (coinTimer <= 0)
        {
            SpawnCoin();
            coinTimer = Random.Range(coinSpawnRate.x, coinSpawnRate.y);
        }
    }

    void SpawnHazard()
    {
        float xPos = Random.Range(-cameraX + 5, cameraX - 5);
        float yPos = Random.Range(-cameraY + 2, cameraY - 2);
        Vector3 pos = new Vector3(xPos, yPos, 0);
        Instantiate(Hazard, pos, Quaternion.identity);
        
    }

    
    void SpawnCoin()
    {
        float xPos = Random.Range(-cameraX + 5, cameraX - 5);
        float yPos = Random.Range(-cameraY + 2, cameraY - 2);
        Vector3 pos = new Vector3(xPos, yPos, 0);
        Instantiate(coin, pos, Quaternion.identity);
    }
}
