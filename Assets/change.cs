using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class change : MonoBehaviour
{
    public int s;
    public GameObject speedtxt;
    public GameObject Slider;
    public int c = 0;
    public GameObject slider;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ch()
    {
        SceneManager.LoadScene("mainscene");
        PlayerPrefs.SetFloat("Speed", slider.GetComponent<UnityEngine.UI.Slider>().value);
    }
    public void speed()
    {
        if (c == 0)
        {
            speedtxt.SetActive(true);
            Slider.SetActive(true);
            c = 1;
        }
        else
        {
            speedtxt.SetActive(false);
            Slider.SetActive(false);
            c = 0;
        }
        
    }
}
