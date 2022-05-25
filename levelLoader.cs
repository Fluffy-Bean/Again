using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour
{
  public void NextLevel()
  {
    if (SceneManager.GetActiveScene().name == "menu")
    {
      PlayerPrefs.SetFloat("lowestTime",9999f);
    }
    SceneManager.LoadScene("game");
    Time.timeScale = 1f;
  }
}
