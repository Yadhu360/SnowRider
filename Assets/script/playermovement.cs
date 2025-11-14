using UnityEngine;

public class playermovement : MonoBehaviour
{
    [SerializeField] float torqamnt = 0f;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
    }
    private void Rotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(torqamnt);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(-torqamnt);
        }
       
    }
}
