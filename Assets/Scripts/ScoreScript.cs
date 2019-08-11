using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public static int scoreValue = 0;
    Text score;

    public GameObject wolken;
    public GameObject veg1;
    public GameObject veg2;
    public GameObject veg3;
    public GameObject veg4;
    public GameObject veg5;
    public GameObject veg6;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>(); // searches the text component to make changes
    }

    // Update is called once per frame
    void Update()
    {
        score.text = scoreValue.ToString();

        if (scoreValue >= 100){ // when the score adds up, more of the world will become visible
            wolken.SetActive(true);
        }
        if (scoreValue >= 300)
        {
            veg1.SetActive(true);
        }
        if (scoreValue >= 500)
        {
            veg2.SetActive(true);
        }
        if (scoreValue >= 700)
        {
            veg3.SetActive(true);
        }
        if (scoreValue >= 1000)
        {
            veg4.SetActive(true);
        }
        if (scoreValue >= 1300)
        {
            veg5.SetActive(true);
        }
        if (scoreValue >= 1500)
        {
            veg6.SetActive(true);
        }
    }
}
