using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManger : MonoBehaviour
{
   private int level;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        level = 0;
    }

    public void nextlevel()
    {
        if (level == 0)
        {
            SceneManager.LoadScene("tutorial");
            level = 1;
        }
        else if (level == 1)
        {
            SceneManager.LoadScene("Level1");
            level = 2;
        }
        else if (level == 2)
        {
            SceneManager.LoadScene("Level2");
            level = 3;
        }
        else if (level == 3)
        {
            SceneManager.LoadScene("Level3");
            // game completed
        }
        
    }



}
