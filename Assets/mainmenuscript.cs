using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenuscript : MonoBehaviour
{
  public void PlayGame() {
        PlayerPrefs.SetInt("Score", 0);

        SceneManager.LoadScene("MainScene");
  }

}
