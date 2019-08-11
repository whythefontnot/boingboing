using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    public AudioSource soundSource;
    public Renderer rend;
    public float lifetime = 1;

    // Start is called before the first frame update
    void Start()
    {
        soundSource = GetComponent<AudioSource>();
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }


    private void OnCollisionEnter(Collision collision)
    {
        soundSource.Play(); // play sound on collision
        print("we gettin there");
        rend.enabled = false;

        // add different scores for different platforms

        if (gameObject.tag == "platform1")
        {
        ScoreScript.scoreValue += 100;
        }
        if (gameObject.tag == "platform2")
        {
            ScoreScript.scoreValue += 200;
        }
        if (gameObject.tag == "platform3")
        {
            ScoreScript.scoreValue += 300;
        }
        if (gameObject.tag == "platform4")
        {
            ScoreScript.scoreValue += 400;
        }
        if (gameObject.tag == "platform5")
        {
            ScoreScript.scoreValue += 500;
        }

        Destroy(gameObject, lifetime);

    }
}
