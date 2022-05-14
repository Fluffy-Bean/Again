using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class endScreenScore : MonoBehaviour
{
  TextMeshProUGUI textBox;
  public float endTime = 0;

  void Start()
  {
    Cursor.lockState = CursorLockMode.None;
    endTime = PlayerPrefs.GetFloat("timeScore");
    textBox = GetComponent<TextMeshProUGUI>();
    textBox.SetText("Time: {0}s", endTime);
  }
}
