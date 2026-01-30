using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComboSysteem : MonoBehaviour
{
    int scoreMultiplier = 1;
    private List<string> bumperTags = new List<string>();
    public static event Action<int, int> OnScoreChange;
    private void CheckForCombo(string tag, int bumperValue)
    {
        bumperTags.Add(tag);
        if (bumperTags.Count > 1)
        {
            if (bumperTags[bumperTags.Count - 2] == bumperTags[bumperTags.Count - 1])
            {
                scoreMultiplier++;
            }
            else
            {
                scoreMultiplier = 1;
                bumperTags.Clear();
            }
            scoreManager.Instance.AddScore(bumperValue * scoreMultiplier);

            OnScoreChange?.Invoke(scoreManager.Instance.score, scoreMultiplier);
        }
    }

    void Start()
    {
        BumperHit.onBumperHit += CheckForCombo;
    }

    private void OnDisable()
    {
        BumperHit.onBumperHit -= CheckForCombo;
    }


}
