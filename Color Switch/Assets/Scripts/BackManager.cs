using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackManager : MonoBehaviour
{
   
    public void levelButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }

    public void contactButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-12);
    }
    public void levelSelect(int levelNumber){
        SceneManager.LoadScene("Level" + levelNumber);
    }
    

}
