using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D collision){

    if (collision.tag == "ball"){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +11);
    }
   }


}
