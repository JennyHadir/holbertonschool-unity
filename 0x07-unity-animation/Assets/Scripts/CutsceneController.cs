using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneController : MonoBehaviour
{
    public GameObject player;
    public GameObject TimerCav;
    public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //

    void camSwitch()
    {
   
        TimerCav.SetActive(true);
        player.GetComponent<PlayerController>().enabled = true;
        gameObject.SetActive(false);
        Camera.SetActive(true);

    }

}
