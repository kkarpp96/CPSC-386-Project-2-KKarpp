using UnityEngine;

public class Switch : MonoBehaviour
{
    public int switchId;
    public VictoryTrigger controller;
    public AudioSource switchSFX;
    public ParticleManager particlemanager;

    private bool activated = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (activated) return;
        activated = true;
        if (other.CompareTag("Player")) {
            // Game Logic
            Debug.Log("switch pressed");
            controller.ActivateSwitch(switchId);

            // Play Effects
            switchSFX.Play();
            particlemanager.Play(transform.position);

            gameObject.SetActive(false);
        }
    }
}
