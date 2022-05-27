using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    public GameObject Player;
    public GameObject Camera;
    public GameObject Timer;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Switch());
    }

    IEnumerator Switch()
    {
        yield return new WaitForSeconds(4.0f);
        Camera.SetActive(true);
        Timer.SetActive(true);
        gameObject.SetActive(false);
        Player.GetComponent<PlayerController>().enabled = true;
    }
}
