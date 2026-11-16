using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource collectSFX;
    public ParticleManager particlemanager;
    public Counter counter;

    public void Init(AudioSource sfx, ParticleManager particle, Counter counterText)
    {
        collectSFX = sfx;
        particlemanager = particle;
        counter = counterText;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground") || other.CompareTag("Collectible")) Destroy(gameObject);
        if (other.CompareTag("Player"))
        {
            counter.Collect();
            collectSFX.Play();
            particlemanager.Play(transform.position);
            Destroy(gameObject);
        }
    }
}
