using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    private AudioSource auidosrc;
    private float musicVolume;
    // Start is called before the first frame update
    void Start()
    {
        auidosrc=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        auidosrc.volume = musicVolume;
    }
    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}
