using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour {

    public void Load_First_Level()
    {
        SceneManager.LoadScene(1);
    }
}
