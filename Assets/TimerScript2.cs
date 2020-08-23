using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using UnityEngine.SceneManagement;



public class TimerScript2 : MonoBehaviour
{
    int timelimit = 30;
    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }

    // Update is called once per frame
    void Update()
    {


    }

    void countDownTimer(){
      //TimeSpan spanTime = TimeSpan.FromSeconds(timelimit);
      //timerUI.text = "Timer: " + spanTime.Minutes + ": "+ spanTime.Seconds;
      if (timelimit > 0) {
        //Debug.Log("Timer: "+timelimit);
        timelimit--;
        Invoke("countDownTimer",1.0f);
      }
      else {
        //Debug.Log("Game Complete");
        SceneManager.LoadScene("GameComplete");

      }
    }
    void OnGUI()
    {
        GUI.Box(new Rect(81, 0, 150, 30), "Time Remaining: " + timelimit.ToString());

    }
  }
