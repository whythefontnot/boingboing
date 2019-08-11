using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject); // makes sure the audio/background music keeps playing. music doesn't restart in next level
    }
}
