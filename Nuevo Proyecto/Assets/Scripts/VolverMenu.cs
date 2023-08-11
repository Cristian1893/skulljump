using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverMenu : MonoBehaviour
{
    public void changeScena(int scena)
    {
        //AudioManager.Instance.musicSource.Stop();
        //Destroy(AudioManager.Instance);
        Time.timeScale = 1f;
        SceneManager.LoadScene(scena);

    }
}
