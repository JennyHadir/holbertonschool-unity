using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goUrl : MonoBehaviour
{
    public void ToGithub() {
        Application.OpenURL ("https://github.com/JennyHadir");
    }
    public void ToTwitter() {
        Application.OpenURL ("https://twitter.com/HadirJenni");
    }
    public void ToMail() {
        Application.OpenURL ("mailto:hadirjenni@gmail.com");
    }
    public void ToLinkedin() {
        Application.OpenURL ("https://www.linkedin.com/in/hadir-jenni-9813791b6/");
    }
}
