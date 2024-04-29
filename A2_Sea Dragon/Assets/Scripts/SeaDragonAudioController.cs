using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaDragonAudioController : MonoBehaviour
{
    public AudioSource audioSource; // Single AudioSource

    private Dictionary<string, AudioClip> sounds;
    // Start is called before the first frame update


    private void Start()
    {
        sounds = new Dictionary<string, AudioClip>();
        sounds.Add("fire1", Resources.Load<AudioClip>("dragon fire breath"));
        sounds.Add("eating", Resources.Load<AudioClip>("eating sound"));

    }

    public void PlaySound(string eventName)
    {
        if (sounds.TryGetValue(eventName, out AudioClip clip))
        {
            audioSource.PlayOneShot(clip);
        }
        else
        {
            Debug.LogWarning("Sound not found for event: " + eventName);
        }
    }
    public void StopSound(string eventName)
    {
        audioSource.Stop();
    }


    // Update is called once per frame
    void Update()
    {
        if (SeaDragonMain.isFire1Pressed)
        {
            PlaySound("fire1");
        }
        if (SeaDragonMain.isEating)
        {
            PlaySound("eating");
        }
    }
}
