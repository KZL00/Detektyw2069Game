using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float currentTime;
    public float startTime;

    public TMP_Text TimeLeftCounter;
    
    void Start()
    {
        currentTime = startTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        TimeLeftCounter.text = $"{(int)currentTime} seconds left";
        

        if (currentTime <= 0)
        {
            SceneManager.LoadScene("LevelFailed");
        }
    }
}
