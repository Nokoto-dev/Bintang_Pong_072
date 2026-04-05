using UnityEngine;
using TMPro; // WAJIB ADA agar bisa kontrol teks

public class GameManager : MonoBehaviour
{
    [SerializeField] private int scorePlayer = 0;
    [SerializeField] private int scoreAI = 0;

    [SerializeField] private TextMeshProUGUI playerText; // Untuk slot skor kiri
    [SerializeField] private TextMeshProUGUI aiText;     // Untuk slot skor kanan
    [SerializeField] private Ball ballScript;            // Untuk reset bola

    void Start()
    {
        UpdateUI();
    }

    public void PlayerGoal()
    {
        scorePlayer++;
        UpdateUI();
        CheckWinner();
    }

    public void AIGoal()
    {
        scoreAI++;
        UpdateUI();
        CheckWinner();
    }

    private void UpdateUI()
    {
        playerText.text = scorePlayer.ToString();
        aiText.text = scoreAI.ToString();
    }

    private void CheckWinner()
    {
        // Ketentuan dosen: Menang jika mencapai skor 11
        if (scorePlayer >= 11 || scoreAI >= 11)
        {
            Debug.Log("Permainan Berakhir!");
            Time.timeScale = 0; // Menghentikan seluruh pergerakan game
        }
        else
        {
            ballScript.ResetBall(); // Bola balik ke tengah untuk ronde baru
        }
    }
}