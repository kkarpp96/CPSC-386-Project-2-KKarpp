using System.Collections.Generic;
using UnityEngine;

public class VictoryTrigger : MonoBehaviour
{
    [SerializeField] private GameRules gamerules;

    public bool goal_unlocked = true;
    public int totalSwitches = 4;
    private HashSet<int> activatedSwitches = new HashSet<int>();

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && goal_unlocked)
        {
            gamerules.Victory();
        }
    }

    public void ActivateSwitch(int switchId)
    {
        // Add returns false when the ID is already in the set, so a duplicate is ignored
        if (!activatedSwitches.Add(switchId)) return;
        Debug.Log("Switch " + switchId + " activated (" + activatedSwitches.Count + "/" + totalSwitches + ")");
        if (activatedSwitches.Count == totalSwitches)
        {
            SpriteRenderer renderer = GetComponent<SpriteRenderer>();
            renderer.color = new Color(0.5f, 1f, 0f, 1.0f);
            goal_unlocked = true;
        }
    }
}
