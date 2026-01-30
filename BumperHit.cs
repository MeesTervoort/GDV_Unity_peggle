using System;
using UnityEngine;

public class BumperHit : MonoBehaviour
{
    [SerializeField] private int scoreValue = 100;

    private ParticleSystem ps;

    public static event Action<Transform, int> onHitBumper;


    private void Start()
    {
        ps = GetComponent<ParticleSystem>();
        ps?.Stop();
    }

    public static event Action<string, int> onBumperHit;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BALLER"))
        {
            onBumperHit?.Invoke(gameObject.tag, scoreValue);
            ps?.Stop();
            ps?.Play();
        }


    }

}
