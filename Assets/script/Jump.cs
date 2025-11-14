using UnityEngine;

public class jump : MonoBehaviour
{
    [SerializeField] float jumpForce = 1f;
    Rigidbody2D rb;
    bool isGround;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&isGround)
        {
            rb.AddForce(Vector3.up * jumpForce, (ForceMode2D)ForceMode.Impulse);
            isGround = false;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
            if (collision.gameObject.CompareTag("Ground"))
            {
                isGround = true;
            }
    }
}

