using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Movement : MonoBehaviour
{
    //movement is either mouse based.... which I'm thinking right now implement karna easy hoga, or touch based on android... filhaal mouse based karte hain... android ka baad me sochenge
    // also, we have roetron productions ka logo for the home screen too
    public float sensitivity = 0.25f;
    Rigidbody2D playerCharacter;
    SceneManager sceneManager;
    [SerializeField]Text text;
    [SerializeField] Text highScore;
    float timee = 0f;
    int timeee = 0;
    // Start is called before the first frame update
    void Start()
    {
        timee = 0f;
        playerCharacter = GetComponent<Rigidbody2D>();

        highScore.text = "HighScore: " + PlayerPrefs.GetInt("Highscore", 0);
    }



    //Okay we need screen dimensions;

    // Update is called once per frame
    void Update()
    {
        timee += Time.deltaTime;
        timeee = (int)timee;
        text.text = "Score: " + timeee.ToString();
        float horizontalMovement= Input.GetAxis("Mouse X")*sensitivity;
        float verticalMovement = Input.GetAxis("Mouse Y")*sensitivity;
        playerCharacter.position += new Vector2(horizontalMovement, verticalMovement);
        playerCharacter.position =new Vector2(Mathf.Clamp(playerCharacter.position.x, -8f, 8f), Mathf.Clamp(playerCharacter.position.y, -4f, 3f)) ;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Takraya hu mai: " + collision.collider.ToString());
        Death();
        
    }

    private void Death()
    {
        if (timeee > PlayerPrefs.GetInt("Highscore", 0)) PlayerPrefs.SetInt("Highscore", timeee);
        PlayerPrefs.SetInt("CurrentScore", timeee);
        SceneManager.LoadScene("GameOver");
    }
}
