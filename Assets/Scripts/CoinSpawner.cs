using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public Coin prefab;

    public AudioSource coinSFX;
    public ParticleManager particlemanager;
    public Counter counter;

    public int max_coins = 20;

    void Start()
    {
        for (int x = 0; x < max_coins; x++)
        {
            float xPos = Random.Range(-17f, 17f);
            float yPos = Random.Range(-8f, 3f);
            Coin obj = Instantiate(prefab, new Vector2(xPos, yPos), Quaternion.identity);
            obj.Init(coinSFX, particlemanager, counter);
        }
    }
}