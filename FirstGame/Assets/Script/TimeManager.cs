using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField] string m_loadScene;
    [SerializeField] float m_countdown = 0f;
    float m_timer;
    [SerializeField] Text m_text;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreManager sm = GetComponent<ScoreManager>();
        m_timer += Time.deltaTime;
        //m_countdown -= m_timer;
        m_text.text = "制限時間 :  " + (m_countdown - m_timer).ToString("n2");

        if(m_timer >= m_countdown)
        {
            sm.m_clearscore = sm.m_score;
            SceneManager.LoadScene(m_loadScene);
        }
    }
}
