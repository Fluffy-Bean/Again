using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
  // Scene changer
  public void NextLevel()
  {
    SceneManager.LoadScene("game");
    Time.timeScale = 1f;
  }
  public void MainMenu()
  {
    SceneManager.LoadScene("menu");
  }
  public void Settings()
  {
    SceneManager.LoadScene("settings");
  }

  // Buttons
  public void ExitGame()
  {
    Application.Quit();
  }
  public void ResetScore()
  {
    PlayerPrefs.SetFloat("lowestTime",999999f);
  }

  // Sliders
  public AudioMixer audioMixer;
  public void SetVolume(float volume)
  {
    audioMixer.SetFloat("Volume", volume);
  }
}
