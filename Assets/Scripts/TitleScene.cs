using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour {

    private AudioSource aud;

    public void Start()
    {
        aud = GetComponent<AudioSource>();
        aud.Play();
    }

    public void Load_First_Level()
    {
        SceneManager.LoadScene(1);
    }
}
