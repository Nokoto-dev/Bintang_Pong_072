using UnityEngine;

public class PlayerPaddle : MonoBehaviour
{
    // [SerializeField] agar variabel muncul di Inspector sesuai perintah dosen
    [SerializeField] private float speed = 10f;
    [SerializeField] private Rigidbody2D rb;

    void Update()
    {
        // Mengambil input Vertical (W/S atau Panah) yang sudah kamu setting tadi
        float moveInput = Input.GetAxisRaw("Vertical");

        // Menggunakan Konsep Fisika (Velocity) sesuai perintah dosen
        rb.linearVelocity = new Vector2(0, moveInput * speed);
    }
}