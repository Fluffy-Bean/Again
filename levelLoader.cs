using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour
{
  public void NextLevel()
  {
    SceneManager.LoadScene("game");
  }
}
