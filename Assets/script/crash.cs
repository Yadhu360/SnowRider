using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadHitRestart : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Head"))
        {
            // Optional: Check if player hit the object from below (i.e., with their head)
            foreach (ContactPoint2D contact in collision.contacts)
            {
                if (contact.normal.y < -0.5f)
                {
                    Debug.Log("Player hit head! Restarting level...");
                    RestartLevel();
                    break;
                }
            }
        }
    }

    void RestartLevel()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}
