using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager soundsInstance;
    private void Awake()
    {
        soundsInstance = this;  
    }

    public AudioClip[] sfx_Audio;
    public AudioClip[] music_Audio;

    public GameObject soundObject;

    public GameObject currentMusicPlayer;

    public void PlaySFX(int index)
    {
        switch (index)
        {
            case 1:
                SoundObjectPlay(sfx_Audio[0]);
                break;
            case 2:
                SoundObjectPlay(sfx_Audio[1]);
                break;
            case 3:
                SoundObjectPlay(sfx_Audio[2]);
                break;
            case 4:
                SoundObjectPlay(sfx_Audio[3]);
                break;


            default:
                break;
        }

        void SoundObjectPlay(AudioClip audioclip )
        {
            GameObject soundProxy = Instantiate(soundObject , transform);
            soundProxy.GetComponent<AudioSource>().clip = audioclip ;

            soundProxy.GetComponent<AudioSource>().Play();
        }

    }

    public void PlayMusic(int index)
    {
        switch (index)
        {
            case 1:
                MusicObjectPlay(music_Audio[0]);
                break;
            case 2:
                MusicObjectPlay(music_Audio[1]);
                break;
            case 3:
                MusicObjectPlay(music_Audio[2]);
                break;
            case 4:
                MusicObjectPlay(music_Audio[3]);
                break;


            default:
                break;
        }

        void MusicObjectPlay(AudioClip audioclip)
        {
            if (currentMusicPlayer)
                Destroy(currentMusicPlayer);
            currentMusicPlayer = Instantiate(soundObject, transform);
            currentMusicPlayer.GetComponent<AudioSource>().clip = audioclip;
            currentMusicPlayer.GetComponent<AudioSource>().loop = true;
            currentMusicPlayer.GetComponent<AudioSource>().Play();
        }


    }
}
