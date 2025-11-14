using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnCollision2D : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Restart"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
