using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("UI")]
    public TMP_Text scoreText;
    public TMP_Text coinText;
    public TMP_Text timerText;
    public TMP_Text hitsText;
    public TMP_Text winStatsText;
    public TMP_Text gameOverStatsText;

    [Header("Panels")]
    public GameObject winPanel;
    public GameObject gameOverPanel;

    [Header("Game Settings")]
    public int maxHits = 3;

    [Header("Audio Clips")]
    public AudioClip backgroundMusic;
    public AudioClip coinSound;
    public AudioClip hitSound;
    public AudioClip winSound;
    public AudioClip gameOverSound;

[Header("Audio Sources")]
    public AudioSource  musicSource;
    public AudioSource sfxSource;      

    // Game Data
    private int score = 0;
    private int coins = 0;
    private int hits = 0;
    private float timer = 0f;

    private bool gameEnded = false;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        winPanel.SetActive(false);
        gameOverPanel.SetActive(false);

        musicSource.clip = backgroundMusic;
        musicSource.loop = true;
        musicSource.Play();

        UpdateUI();
    }

    void Update()
    {
        if (gameEnded)
            return;

        timer += Time.deltaTime;

        timerText.text = "Time : " + timer.ToString("F1") + " s";
    }

    // ---------------- SCORE ----------------

    public void AddScore(int amount)
    {
        score += amount;
        UpdateUI();
    }

    // ---------------- COINS ----------------

    public void CollectCoin()
    {
        coins++;
        score += 10;

        sfxSource.PlayOneShot(coinSound);

        UpdateUI();
    }

    // ---------------- HITS ----------------

    public void AddHit()
    {
        hits++;

        sfxSource.PlayOneShot(hitSound);

        UpdateUI();

        if (hits >= maxHits)
        {
            GameOver();
        }
    }

    // ---------------- WIN ----------------

    public void WinLevel()
    {
        if (gameEnded)
            return;

        gameEnded = true;

        musicSource.Stop();

        sfxSource.PlayOneShot(winSound);

        winStatsText.text =
            "You Win!\n\n" +
            "Score : " + score +
            "\nCoins : " + coins +
            "\nTime : " + timer.ToString("F1") + " s" +
            "\nHits : " + hits + "/" + maxHits;

        winPanel.SetActive(true);

        Time.timeScale = 0f;
    }  

    // ---------------- GAME OVER ----------------

    void GameOver()
    {
        if (gameEnded)
            return;

        gameEnded = true;

        musicSource.Stop();

        sfxSource.PlayOneShot(gameOverSound);

        gameOverStatsText.text =
            "Score : " + score +
            "\nCoins : " + coins +
             "\nTime : " + timer.ToString("F1") + " s" +
            "\nHits : " + hits + "/" + maxHits;

        gameOverPanel.SetActive(true);

        Time.timeScale = 0f;
    }   

    // ---------------- RESTART ----------------

    public void RestartGame()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // ---------------- UI ----------------

    void UpdateUI()
    {
        scoreText.text = "Score : " + score;
        coinText.text = "Coins : " + coins;
        hitsText.text = "Hits : " + hits + "/" + maxHits;
    }
}