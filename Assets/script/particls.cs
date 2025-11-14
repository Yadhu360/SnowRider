using UnityEngine;

public class PlayerDustControllerWithTag : MonoBehaviour
{
    public ParticleSystem playerDust;
   
    void Update()
    {
      
    }

    // Trigger-based grounding detection

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            playerDust.Play();
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            playerDust.Stop();
        }
    }
}
