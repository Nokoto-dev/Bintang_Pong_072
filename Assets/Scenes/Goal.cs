using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private bool isAIGoal; // Centang ini jika gol untuk AI (di belakang Player)
    [SerializeField] private GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            if (isAIGoal) gameManager.AIGoal();
            else gameManager.PlayerGoal();
        }
    }
}