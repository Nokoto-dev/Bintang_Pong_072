using UnityEngine;

public class PlayerPaddle : MonoBehaviour
{
    // [SerializeField] agar variabel muncul di Inspector dan bisa diatur langsung dari Unity Editor
    [SerializeField] private float speed = 10f;
    [SerializeField] private Rigidbody2D rb;

    void Update()
    {
        // Mengambil input Vertical (W/S) yang sudah setting 
        float moveInput = Input.GetAxisRaw("Vertical");

        // Menggunakan Konsep Fisika
        rb.linearVelocity = new Vector2(0, moveInput * speed);
    }
}