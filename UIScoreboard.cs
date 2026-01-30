using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UIScoreboard : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI ScoreField;
    [SerializeField] private TextMeshProUGUI MarkiplierField;

    void Start()
    {
        ComboSysteem.OnScoreChange += UpdateUI;
    }

    private void OnDisable()
    {
        ComboSysteem.OnScoreChange -= UpdateUI;
    }
    private void UpdateUI(int Score, int markiplier)
    {
        ScoreField.text = "Score: " +Score;
        MarkiplierField.text = "Markiplier: " +markiplier+ "X";
    }
}
