using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreManager : MonoBehaviour
{
    public static scoreManager Instance;
    public int score = 0;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void AddScore(int amount)
    {
        score = score + amount;
        Debug.Log("Score: " + score);
    }
}
