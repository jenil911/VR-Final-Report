using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public AudioSource CoinCollection;

    void Start()
    {
        // Initialization code, if needed
    }

    void Update()
    {
        // Update code, if needed
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            // Play the coin collection sound
            CoinCollection.Play();
        }
    }
}
