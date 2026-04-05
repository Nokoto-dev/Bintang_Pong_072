using UnityEngine;

public class AIPaddle : MonoBehaviour
{
    [SerializeField] private float speed = 8f; // AI dibuat sedikit lebih lambat agar pemain bisa menang
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform ball; // Tarik objek Bola ke sini di Inspector

    void Update()
{
    if (ball != null)
    {
        // Jika bola terlalu jauh di kiri/kanan (sudah gol), AI berhenti diam
        if (Mathf.Abs(ball.position.x) > 12f) 
        {
            rb.linearVelocity = Vector2.zero;
            return;
        }

        float direction = 0;
        // Gunakan jarak toleransi (0.2f) agar AI tidak gemetar/lewat batas
        if (ball.position.y > transform.position.y + 0.2f) direction = 1;
        else if (ball.position.y < transform.position.y - 0.2f) direction = -1;

        rb.linearVelocity = new Vector2(0, direction * speed);
    }
}
}