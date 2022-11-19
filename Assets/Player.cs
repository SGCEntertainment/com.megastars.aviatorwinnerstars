using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{

    public static Player instance;
    private float speed;
    public float normalspeed;
    private Rigidbody2D rb;
    public int score;

    public TextMeshProUGUI scoreText;

    [SerializeField] private GameObject bullet;

    [SerializeField] private GameObject trans;
    private void Start()
    {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, 0);
        scoreText.text = score.ToString();
    }

    public void OnLeftButton()
    {
        if (speed >= 0f)
        {
            speed -= normalspeed;
        }
    }
    public void OnRightButton()
    {
        if (speed <= 0f)
        {
            speed += normalspeed;
        }
    }
    public void OnButtonUp()
    {
        speed = 0f;
    }
    public void Shoot()
    {
        Instantiate(bullet, trans.transform.position, Quaternion.identity);
    }
}
