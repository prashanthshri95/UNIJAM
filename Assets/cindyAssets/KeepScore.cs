using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class KeepScore : MonoBehaviour
{
    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = PlayerPrefs.GetInt("Score", 0);
    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnGUI()
    {
        GUI.Box(new Rect(100, 100, 100, 100), PlayerPrefs.GetInt("Score").ToString());

    }

}