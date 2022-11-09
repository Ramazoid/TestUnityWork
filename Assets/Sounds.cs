using AxGrid.Base;
using AxGrid.Model;
using AxGrid.Path;
using System.Collections.Generic;
using UnityEngine;


public class Sounds : MonoBehaviourExtBind
{
    public List<AudioClip> sounds;
    private AudioSource player;

    [OnStart]

    private void Init()
    {
        player = GetComponent<AudioSource>();

    }

    [Bind("PlayBall")]
    void PlayBallSound()
    {
        player.clip = sounds[Random.Range(0, sounds.Count - 1)];
        player.Play();
    }
    
}
