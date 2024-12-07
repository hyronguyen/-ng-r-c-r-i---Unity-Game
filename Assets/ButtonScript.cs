using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;
using JetBrains.Annotations;

public class ButtonScript : MonoBehaviour
{
    public static string name;
    public Text userinputname;
    public GameObject tilp;
    public GameObject creditpanel;
   
    
    public void CloseCreditPanel()
    {
        tilp.SetActive(true);
        creditpanel.SetActive(false);
    }
    public void Credit_Panel()
    {
        tilp.SetActive(false);
        creditpanel.SetActive(true);
    }
    public void LoadNextScene()
    {
       name = userinputname.text;
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
