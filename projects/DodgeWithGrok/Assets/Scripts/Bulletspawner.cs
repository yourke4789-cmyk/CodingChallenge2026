using UnityEngine;

public class Bulletspawner : MonoBehaviour
{
    public GameObject bulletprefabs;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3f;

    public Transform target;
    public float spawnRate;
    public float timeAfterspawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeAfterspawn = 0f;
        target = FindFirstObjectByType<PlayerControler>().transform;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterspawn += Time.deltaTime;
        if (timeAfterspawn >= spawnRate)
        {
            timeAfterspawn = 0f;
            GameObject gameObject = Instantiate(bulletprefabs, transform.position, transform.rotation);
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);

            gameObject.transform.LookAt(target);
        }
    }
}
