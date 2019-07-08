using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SplashTimer : MonoBehaviour
{
    private float timer = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0.0f)
        {
            onFinishTimer();
        }
        
    }
    void onFinishTimer()
    {
        SceneManager.LoadScene("SelectScene");
    }
}
