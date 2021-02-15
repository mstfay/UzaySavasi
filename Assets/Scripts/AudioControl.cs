using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    [SerializeField]
    AudioClip asteroidExplosion;

    [SerializeField]
    AudioClip shipExplosion;

    [SerializeField]
    AudioClip fire;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();    
    }

    public void AsteroidExplosion()
    {
        audioSource.PlayOneShot(asteroidExplosion);
    }

    public void ShipExplosion()
    {
        audioSource.PlayOneShot(shipExplosion);
    }

    public void Fire()
    {
        audioSource.PlayOneShot(fire);
    }
}
