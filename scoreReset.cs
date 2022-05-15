using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreReset : MonoBehaviour
{
  public void SendBack()
  {
    SceneManager.LoadScene("menu");
  }
}
