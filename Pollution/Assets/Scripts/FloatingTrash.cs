using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingTrash : MonoBehaviour
{
    public float floatStrength = 15f;  // 浮力大小
    public float damping = 0.5f;      // 阻尼（減緩浮動幅度）
    public float targetHeight = 1.6f; // 目標浮動高度
    public float waveStrength = 0.2f; // 額外的波浪擾動強度
    public float waveSpeed = 2f;      // 波浪擾動速度

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
            // 計算基本浮力
            float depth = targetHeight - transform.position.y;
            float buoyancyForce = depth * floatStrength - rb.velocity.y * damping;

            // 增加隨機波動，使垃圾持續浮動
            float waveForce = Mathf.Sin(Time.time * waveSpeed) * waveStrength;

            // 套用浮力與波動
            rb.AddForce(new Vector3(0, buoyancyForce + waveForce, 0), ForceMode.Acceleration);
        }
    }
}
