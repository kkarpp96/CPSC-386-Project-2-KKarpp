using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    public AudioSource musicSource;
    public AudioSource jumpsfxSource;
    public AudioSource collectsfxSource;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.Log("Duplicate SoundManager destroyed.");
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        float volume = PlayerPrefs.GetFloat("volume", 0.1f);
        musicSource.volume = volume;
        jumpsfxSource.volume = volume;
        collectsfxSource.volume = volume;
        musicSource.Play();
    }

    public void PlaySfx(AudioClip clip)
    {
        jumpsfxSource.PlayOneShot(clip);
        // Debug.Log("SFX played: " + clip.name);
    }

    public void ChangeVolume(float volume)
    {
        musicSource.volume = volume;
        jumpsfxSource.volume = volume;
        collectsfxSource.volume = volume;
        PlayerPrefs.SetFloat("volume", volume);
        PlayerPrefs.Save();
    }
}