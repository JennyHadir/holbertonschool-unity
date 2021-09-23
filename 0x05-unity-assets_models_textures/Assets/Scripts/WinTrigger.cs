using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public Text TimerText;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider Player)
    {
        Player.GetComponent<Timer>().enabled = false;
        TimerText.color = Color.green;
        TimerText.fontSize = 60;
    }
}
