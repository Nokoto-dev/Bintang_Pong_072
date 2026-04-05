using UnityEngine;

public class Ball : MonoBehaviour
{
    // Menggunakan [SerializeField]
    [SerializeField] private float speed = 10f;
    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        // Jalankan fungsi meluncur saat game dimulai
        Launch();
    }

    private void Launch()
    {
        // 1. Pastikan posisi di tengah 
        transform.position = Vector2.zero;

        // 2. Tentukan arah X dan Y secara acak
        // Random.Range(0, 2) menghasilkan 0 atau 1
        float x = Random.Range(0, 2) == 0 ? -1f : 1f;
        float y = Random.Range(0, 2) == 0 ? -1f : 1f;

        // 3. Gerakkan bola menggunakan konsep Fisika 
        rb.linearVelocity = new Vector2(x * speed, y * speed);
    }

    // Tambahkan ini di script Ball.cs
    public void ResetBall()
    {
        rb.linearVelocity = Vector2.zero; // Hentikan bola dulu
        transform.position = Vector2.zero; // Kembalikan ke tengah
        Launch(); // Panggil fungsi Launch lagi agar bola jalan lagi
    }
}