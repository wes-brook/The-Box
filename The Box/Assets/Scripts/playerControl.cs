using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour {
    //[SerializeField]
    //Vector3 v3Force;
    [SerializeField]
    KeyCode keyPositive = KeyCode.LeftArrow;
    [SerializeField]
    KeyCode keyNegative = KeyCode.RightArrow;

    Rigidbody m_Rigidbody;
    float m_Speed;

    void Start() {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Speed = 10.0f;
    }

    // Update is called once per frame
    void Update() {

        // Using rigidbody
        /* if (Input.anyKey) {
            if (Input.GetKey(keyPositive)) 
                GetComponent<Rigidbody>().velocity += v3Force;

            if (Input.GetKey(keyNegative)) 
                GetComponent<Rigidbody>().velocity -= v3Force;
        } else {
            GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        } */

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
