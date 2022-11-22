using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
   
    public void levelButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void levelSelect(int levelNumber){
        SceneManager.LoadScene("Level" + levelNumber);
    }
    public void quit(){
        Application.Quit();
    }
    public void geriButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-10);
    }
}
