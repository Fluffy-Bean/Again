using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class highScoreCheck : MonoBehaviour
{
  TextMeshProUGUI textBox;
  public float lowestTime;
  void Start()
  {

   if (PlayerPrefs.GetFloat("lowestTime") > PlayerPrefs.GetFloat("timeScore"))
   {
     PlayerPrefs.SetFloat("lowestTime",PlayerPrefs.GetFloat("timeScore"));
   }

   textBox = GetComponent<TextMeshProUGUI>();
   textBox.SetText("Shortest Time: {0}s", PlayerPrefs.GetFloat("lowestTime"));
  }
}
