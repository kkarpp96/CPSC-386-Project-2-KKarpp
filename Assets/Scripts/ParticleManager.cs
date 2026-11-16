using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    public void Play(Vector2 position)
    {
        transform.position = position;
        GetComponent<ParticleSystem>().Play();
    }
}
