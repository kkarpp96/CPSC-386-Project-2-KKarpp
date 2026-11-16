using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameRules : MonoBehaviour
{
    public GameObject playerObject;
    [SerializeField] protected Vector2 start_pos = Vector2.zero;
    [SerializeField] private string next_level = "Level2";
    [SerializeField] private string current_level = "Level1";

    public void Die()
    {
        SceneManager.LoadScene(current_level);
    }

    public void Victory()
    {
        SceneManager.LoadScene(next_level);
    }
}
