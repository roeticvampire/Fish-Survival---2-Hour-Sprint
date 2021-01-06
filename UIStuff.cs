using UnityEngine;
using UnityEngine.UI;
public class UIStuff : MonoBehaviour
{
    [SerializeField] Text text;
    // Start is called before the first frame update
    void Start()
    {
        int highscore= PlayerPrefs.GetInt("Highscore", 0); 
        int Currentscore= PlayerPrefs.GetInt("CurrentScore", 0);
        text.text = "Your Current Score: " + Currentscore + "\nYour High Score: " + highscore;
        
    }

}
