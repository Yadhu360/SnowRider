using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip clip; // Assign in Inspector
    private AudioSource audioSource;

    void Start()
    {
        // Add AudioSource component if not already attached
        audioSource = gameObject.GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the audio clip
        audioSource.clip = clip;

        // Optional settings
        audioSource.playOnAwake = false;  // Don't play automatically on start
        audioSource.loop = false;         // Don't loop

        // Play the clip
        audioSource.Play();
    }
}
