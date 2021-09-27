using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemHPBar : MonoBehaviour
{
    //最大HPと現在のHP。
    GameObject m_gameManager;
    [SerializeField] int m_score = 100;
    public int m_count = 3;
    [SerializeField] float m_speed = 0f;
    Rigidbody2D m_rb;
    bool m_work;


    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        m_gameManager = GameObject.Find("GameManager");
    }
    void Update()
    {
        m_rb.velocity = Vector2.down * m_speed;
        if (m_count <= 0)
        {
            Count();
        }
    }

    //ColliderオブジェクトのIsTriggerにチェック入れること。
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetKeyDown("mouse 0") && collision.gameObject.tag == "Player")
        {
            m_count--;
        }
    }

    void Count()
    {
        Destroy(gameObject);

        ScoreManager sm = m_gameManager.GetComponent<ScoreManager>();
        sm.AddScore(m_score);
    }
}