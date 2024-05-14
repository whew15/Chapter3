using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroInput : MonoBehaviour
{
    public TMP_InputField inputfield;
    public void OnClickBtn()
    {
       if(inputfield.text.Length < 2 || inputfield.text.Length > 10)
        
            return;
       DataManager.instance.userName = inputfield.text;
        SceneManager.LoadScene(0);
    }

}
