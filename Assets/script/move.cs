using TMPro;
using UnityEngine;
using UnityEngine.UI; // Needed if you want to show the score on screen

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float torqueAmount = 5f;
   
    [SerializeField] private TMP_Text scoreText;
// UI Text to display score (optional)

private Rigidbody2D rb;
    private int score = 0;
    private bool isGrounded = false;
    private bool hasSpun = false;
    private float lastRotation;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lastRotation = rb.rotation;
        UpdateScoreUI();
    }

    void Update()
    {
        Rotate();
        CheckSpin();
    }

    private void Rotate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(-torqueAmount);
        }
    }

    private void CheckSpin()
    {
        // Check if the player has rotated significantly
        float rotationChange = Mathf.Abs(rb.rotation - lastRotation);

        if (rotationChange >= 360f) // Full spin
        {
            hasSpun = true;
            lastRotation = rb.rotation; // Reset rotation check
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;

            if (hasSpun)
            {
                score++;
                hasSpun = false; // Reset spin flag
                UpdateScoreUI();
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
