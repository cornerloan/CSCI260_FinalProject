using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] int playerID;
    [SerializeField] AudioClip[] musicSource;
    private AudioSource myAudio;
    private int trackNumber;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        trackNumber = 1;
        //myAudio.PlayOneShot(musicSource[0], 0.7f);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerID == 0)
        {
            InGame();
        }
        else
        {
            NotInGame();
        }
    }

    private void NotInGame()
    {
        if (!myAudio.isPlaying)
        {
            myAudio.PlayOneShot(musicSource[0], 0.7f);
        }
    }

    private void InGame()
    {
        if (!myAudio.isPlaying)
        {
            myAudio.PlayOneShot(musicSource[trackNumber], 0.7f);
            trackNumber++;
            if (trackNumber == 10) trackNumber = 1;
        }
    }
}
