using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    int timelimit = 30;
    public Text timerUI;
    // Start is called before the first frame update
    void Start()
    {
      timerUI.text = "Timer: " + timelimit;
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
        timerUI.text = "Timer: " + timelimit;
        timelimit--;
        Invoke("countDownTimer",1.0f);
      }
      else {
        //Debug.Log("Game Complete");
        SceneManager.LoadScene("GameComplete");

      }
    }
}
