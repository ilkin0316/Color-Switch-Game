using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class contact : MonoBehaviour
{
     public void levelButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+12);
    }
}
