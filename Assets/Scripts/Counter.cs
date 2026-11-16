using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public TMP_Text counterText;
    public int counter = 5;

    public GameRules game_rules;

    public void Collect()
    {
        counter--;
        counterText.text = "Remaining: " + counter;
        if (counter <= 0) {
            game_rules.Victory();
        }
    }
}
