using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public Toggle isInverted;


    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("inveted") == 1)
            isInverted.isOn = true;
        else
            isInverted.isOn = false;
    }
    public void Back()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("prevScene"));
    }

    public void Apply()
    {   
        if (isInverted.isOn)
            PlayerPrefs.SetInt("inverted", 1);
        else
            PlayerPrefs.SetInt("inverted", 0);
        
        Back();
    }
}
