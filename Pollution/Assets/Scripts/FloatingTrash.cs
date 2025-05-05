using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingTrash : MonoBehaviour
{
    public float floatStrength = 15f;  // �B�O�j�p
    public float damping = 0.5f;      // �����]��w�B�ʴT�ס^
    public float targetHeight = 1.6f; // �ؼЯB�ʰ���
    public float waveStrength = 0.2f; // �B�~���i���Z�ʱj��
    public float waveSpeed = 2f;      // �i���Z�ʳt��

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Missing Rigidbody on " + gameObject.name);
        }
    }

    void FixedUpdate()
    {
        if (rb != null)
        {
            // �p��򥻯B�O
            float depth = targetHeight - transform.position.y;
            float buoyancyForce = depth * floatStrength - rb.velocity.y * damping;

            // �W�[�H���i�ʡA�ϩU������B��
            float waveForce = Mathf.Sin(Time.time * waveSpeed) * waveStrength;

            // �M�ίB�O�P�i��
            rb.AddForce(new Vector3(0, buoyancyForce + waveForce, 0), ForceMode.Acceleration);
        }
    }
}
