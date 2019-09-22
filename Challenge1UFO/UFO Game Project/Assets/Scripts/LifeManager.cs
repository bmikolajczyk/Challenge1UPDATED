using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{
    public Text countText;
    public Text loseText;

    private Rigidbody2D rb2d;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        count = 3;
        loseText.text = "";
        SetCountText();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
            count = count - 1;
            SetCountText();
        }
            
    }

    void SetCountText()
    {
        countText.text = "Lives: " + count.ToString();
        if (count <= 0)
        {
            loseText.text = "YOU LOSE!";
            Time.timeScale = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
