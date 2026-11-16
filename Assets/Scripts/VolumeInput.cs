using UnityEngine;
using UnityEngine.UI;

public class VolumeInput : MonoBehaviour
{
    private void Awake()
    {
        Slider slider = GetComponent<Slider>();
        slider.value = PlayerPrefs.GetFloat("volume", 0.1f);

        slider.onValueChanged.AddListener(SoundManager.Instance.ChangeVolume);
    }
}
