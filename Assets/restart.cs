using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
  public void PlayGame2() {
        PlayerPrefs.SetInt("Score", 0);
        SceneManager.LoadScene("MainScene");
  }

}
