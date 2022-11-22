using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class ballControler : MonoBehaviour
{
   
    public AudioSource sescontrol;
    public AudioClip olumsesi;
    public AudioClip ziplamasesi;


    public float jumpforce;
    public  Rigidbody2D rb;
    public string currentColor;
    public Color colorCyan;
    public Color colorYellow;
    public Color colorPink;
    public Color colorPurple;
    public SpriteRenderer sr;

    public int star;
    public TextMeshProUGUI starText;
    Color pink = new Color (250 ,5 ,128,255);
    Color purple = new Color (140 ,19 ,251,255);
    Color yellow = new Color (246 ,223 ,14,255);
    Color cyan = new Color (54 ,224 ,240,255);
    
    // Start is called before the first frame update
    void Start()
    {
        randomColor();
        sescontrol = GetComponent<AudioSource>();

    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Star"){
            ++star;
            starText.text = star.ToString();
            Destroy(col.gameObject);
            return;
        }
        
        
        if(col.tag == "ColorChanger"){
            randomColor();
            Destroy(col.gameObject);
            return;
            
        }
        // ELSE IF ET

        

       


        if(col.tag !=currentColor){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            sescontrol.PlayOneShot(olumsesi,1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)|| Input.GetMouseButtonDown(0)){
            rb.velocity = Vector2.up * jumpforce;
            sescontrol.PlayOneShot(ziplamasesi,0.3f);
        }
    }

    void randomColor(){
        int index = Random.Range(0,4);

        switch(index){
            case 0: currentColor = "Cyan";
                sr.color = colorCyan;
                break;
            case 1: currentColor = "Yellow";
                sr.color = colorYellow;
                break;
            case 2 : currentColor = "Pink";
                sr.color = colorPink;
                break;
            case 3 : currentColor = "Purple";
                sr.color = colorPurple;
                break;

        }
    }
}
