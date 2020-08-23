using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorerender : MonoBehaviour
{
    public Text scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        scoreUI.text = PlayerPrefs.GetInt("Score",0).ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
