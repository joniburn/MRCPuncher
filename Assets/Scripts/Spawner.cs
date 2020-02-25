using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject m_prefab;

    public float m_intervalSec = 5;

    void OnEnable()
    {
        InvokeRepeating("Spawn", m_intervalSec, m_intervalSec);
    }

    // Update is called once per frame
    void OnDisable()
    {
        CancelInvoke();
    }

    private void Spawn() {
        Instantiate(m_prefab, transform);
    }

}
