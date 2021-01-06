using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject creeper1;
    [SerializeField] GameObject creeper2;
    [SerializeField] GameObject stone1;
    [SerializeField] GameObject stone2;
    int spawnObject = 0; //0 for stone 1, 1 for stone 2, 2 for creeper 1, 3 for creeper 2;
    float timedelay = 1f;
    float currentTime = 0f;
    //Okay dekho... yahan we need to spawn two types of creepers...
    /* And now for the not so fun part anyway, we'll create a sad object pool and laugh our way at it
     * Object pool is just a fancy way of saying, we'll create 10 of each kinda obstacle (2 stones and 2 creepers), and then randomly use the queue to queue and dequeue them
     * Also, we need the locations to spawn each of them in... like the stones can come in randomly at any moment... from anywhere in the vertical space
     * 
     * 
     */
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= timedelay)
        {
            currentTime = 0f;
            timedelay = Random.Range(0.05f, 0.3f);
            spawnObject = Random.Range(0, 4);
        if (spawnObject < 2) //spawning  rocks eh?  
        {float spawnPos = Random.Range(-8f, 8f);
                if(spawnObject==0)
                Instantiate(stone1, new Vector3(spawnPos, 5), Quaternion.identity);
else
                    Instantiate(stone2, new Vector3(spawnPos, 5), Quaternion.identity);

            }
            else //  spawn the creepers
            {
                if (spawnObject == 3)
                    Instantiate(creeper2, new Vector3(10f,-3.2f), Quaternion.identity);
                else
                    Instantiate(creeper1, new Vector3(10f, -3.2f), Quaternion.identity);

            }
        }
    }
public  void StartGame()
    {
        SceneManager.LoadScene("Gameloop");
    }

    public void Exit()
    {
        Application.Quit();
    }


}
