using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadMeiro : MonoBehaviour
{
    [SerializeField] GameObject m_loadPanel;
    [SerializeField] GameObject m_player;
    [SerializeField] Text m_timerText;
    float m_loadTime = 20;
    float m_timer = 0f;
    GameObject m_delObj1;
    GameObject m_delObj2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        m_timer += Time.deltaTime;
        m_timerText.text = "残り : " + (m_loadTime - m_timer).ToString("n0") + "秒";

        if (m_timer >= m_loadTime)
        {
            m_loadPanel.SetActive(false);
            m_player.SetActive(true);
            m_delObj1 = GameObject.Find("1-0");
            m_delObj2 = GameObject.Find("1-14");

            Destroy(m_delObj1);
            Destroy(m_delObj2);
        }
    }
}
