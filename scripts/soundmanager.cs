using UnityEngine;
using UnityEngine.Audio;

public class soundmanager : MonoBehaviour
{
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
            audioSource.Play();
    }
}
