using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;
    public static AudioManager instance;
    private string currentSong = null;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Update()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        if (sceneName == "StartMenu")
        {
            CheckStopPlay("MainMenu");
        }
        else if (sceneName == "Credits")
        {
            CheckStopPlay("Credits");
        }
        else if (sceneName.Substring(sceneName.Length - 3, 1) == "1")
        {
            CheckStopPlay("1Fragile");
        }
        else if(sceneName.Substring(sceneName.Length - 3, 1) == "2")
        {
            CheckStopPlay("2RiseNShine");
        }
        else if(sceneName.Substring(sceneName.Length - 3, 1) == "3")
        {
            CheckStopPlay("3Corona");
        }
        else if (sceneName.Substring(sceneName.Length - 3, 1) == "4")
        {
            CheckStopPlay("4BrazilianSF");
        }
        else if (sceneName.Substring(sceneName.Length - 3, 1) == "5")
        {
            CheckStopPlay("5Adventure");
        }
        else if (sceneName.Substring(sceneName.Length - 3, 1) == "E")
        {
            CheckStopPlay("EReachingTheSky");
        }
        else if (sceneName.Substring(sceneName.Length - 3, 1) == "T")
        {
            CheckStopPlay("TForestWalk");
        }
    }

    void CheckStopPlay(string name)
    {
        if (currentSong != name)
        {
            Stop(currentSong);
            currentSong = null;
            Play(name);
        }
    }
    
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            //Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        currentSong = name;
        s.source.Play();
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            //Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Stop();
    }
}
