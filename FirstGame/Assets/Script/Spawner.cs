using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject m_prefab;
    [SerializeField] Transform m_trs;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(m_prefab,m_trs.position, m_prefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            Instantiate(m_prefab,m_trs.position, m_prefab.transform.rotation);
            Destroy(collision.gameObject);
        }
    }
}