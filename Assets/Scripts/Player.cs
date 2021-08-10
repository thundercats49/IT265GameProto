using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public float playerSpeed;

    private Rigidbody2D rb;

    private Vector2 playerDirection;

    public int collects = 0;

    public TMP_Text collectsAmount;

    public TMP_Text highscore;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (!PlayerPrefs.HasKey("highscore"))
        {
            PlayerPrefs.SetInt("highscore", 0);
            PlayerPrefs.Save();
        }
        highscore.text = "Highscore: " + PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    void Update()
    {
       float directionY = Input.GetAxisRaw("Vertical");
       playerDirection = new Vector2(0, directionY).normalized;
    }

    void FixedUpdate()
    {
       rb.velocity = new Vector2(0, playerDirection.y * playerSpeed); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "TBS")
        {
            collects++;
            collectsAmount.text = "Thoughts Collected: " + collects;
            Destroy(collision.gameObject);
        }

    }
  }
