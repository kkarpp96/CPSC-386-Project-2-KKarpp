using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private PlayerMovement movement;

    private void Start()
    {
        movement = GetComponentInParent<PlayerMovement>();
    }

    public void TriggerAnimationEvent()
    {
        movement.IncreaseSpeed();
    }
}
