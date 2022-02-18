using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower = 3.0f;
    public AudioClip[] ad;
    public int Life = 1;
    Transform tf;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tf = GetComponent<Transform>();
        EventCheck();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().clip = ad[Random.Range(0, 2)];
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(Score.score > Score.bestScore)
        {
            Score.bestScore = Score.score;
        }
        Life--;
        if(Life == 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
        else
        {
            if(collision.gameObject.name != "Ground")
            {
                Destroy(collision.gameObject);
            }
            else
            {
                tf.position = Vector3.zero;
            }
        }
    }
    void EventCheck()
    {
        if (ItemList.Items["DisposableShield"] > 0 && ItemList.UseItems["DisposableShield"])
        {
            Life++;
            ItemList.Items["DisposableShield"]--;
        }
    }
}
