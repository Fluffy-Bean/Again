using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class highScoreCheck : MonoBehaviour
{
  TextMeshProUGUI textBox;
  public float highScore = 0;

  void Start()
  {
   highScore = PlayerPrefs.GetFloat("highScore");
   if (highScore > PlayerPrefs.GetFloat("timeScore"))
   {
     PlayerPrefs.SetFloat("highScore",PlayerPrefs.GetFloat("timeScore"));
     highScore = PlayerPrefs.GetFloat("timeScore");
   }

   textBox = GetComponent<TextMeshProUGUI>();
   textBox.SetText("Shortest Time: {0}s", highScore);
  }
}
