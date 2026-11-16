using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    public AudioSource musicSource;

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
        musicSource.volume = PlayerPrefs.GetFloat("volume", 0.1f);
        musicSource.Play();
    }

    public void ChangeVolume(float volume)
    {
        musicSource.volume = volume;
        PlayerPrefs.SetFloat("volume", volume);
        PlayerPrefs.Save();
    }
}