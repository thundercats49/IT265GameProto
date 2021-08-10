using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if(collision.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            if (player.collects > PlayerPrefs.GetInt("highscore"))
            {
                PlayerPrefs.SetInt("highscore",player.collects);
                PlayerPrefs.Save();
                Debug.Log($"new highscore: { player.collects } ");
            }
            SceneManager.LoadScene("Runner");
        }
    }

    
}
