using UnityEngine;

public class HighScoreManager : MonoBehaviour
{
    public static HighScoreManager Instance { get; private set; }

    public int HighScore { get; private set; }
    public string HighScorePlayer { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            LoadHighScore();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CheckForHighScore(int score, string playerName)
    {
        if (score > HighScore)
        {
            HighScore = score;
            HighScorePlayer = playerName;

            SaveHighScore();
        }
    }

    private void SaveHighScore()
    {
        PlayerPrefs.SetInt("HighScore", HighScore);
        PlayerPrefs.SetString("HighScorePlayer", HighScorePlayer);
        PlayerPrefs.Save();
    }

    private void LoadHighScore()
    {
        HighScore = PlayerPrefs.GetInt("HighScore", 0);
        HighScorePlayer = PlayerPrefs.GetString("HighScorePlayer", "");
    }
}
