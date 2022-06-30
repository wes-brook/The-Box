using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour {
    [SerializeField] KeyCode keyPositive = KeyCode.LeftArrow;
    [SerializeField] KeyCode keyNegative = KeyCode.RightArrow;

    Rigidbody m_Rigidbody;
    [SerializeField] float m_Speed = 10.0f;

    void Start() {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {

        // Using transform
        if (Input.anyKey) {
            if (Input.GetKey(KeyCode.LeftArrow)) {
                m_Rigidbody.velocity = transform.forward * m_Speed;
            }

            if (Input.GetKey(KeyCode.RightArrow)) {
                m_Rigidbody.velocity = -transform.forward * m_Speed;
            }
        } else {
            m_Rigidbody.velocity = new Vector3(0,0,0);
        }
    }
}
