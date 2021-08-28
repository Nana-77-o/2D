using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Times : MonoBehaviour
{
    float time = 30.0f;
    [SerializeField] Text text;

    void Update()
    {
        time -= Time.deltaTime;
        text.text = time.ToString("f1");
        if(time <= 0)
        {
           SceneManager.LoadScene("Rizart");
        }        
    }
}
