using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("Audio Clip")]
    public AudioClip explosion;
    public AudioClip powerup;
    public AudioClip teleportSFX;
    public AudioClip UiClick;
    public AudioClip bgMusic;

    private void Start()
    {
        musicSource.clip = bgMusic;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void playSFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
