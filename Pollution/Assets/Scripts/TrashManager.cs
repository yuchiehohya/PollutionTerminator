using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrashManager : MonoBehaviour
{
    public static TrashManager Instance; // 單例模式
    public GameObject victoryPanel; // 拖入 UI 物件

    private int trashCount; // 記錄垃圾數量

    private void Awake()
    {
        // 確保 `Instance` 唯一，避免場景中有多個 `TrashManager`
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    private void Start()
    {
        if (victoryPanel == null)
        {
            Debug.LogError("VictoryPanel 尚未設定，請在 Inspector 設定它！");
        }

        // 計算場景中所有 "Trash" 物件
        trashCount = GameObject.FindGameObjectsWithTag("Trash").Length;
        Debug.Log("初始 Trash 數量：" + trashCount);
    }

    public void RemoveTrash()
    {
        if (trashCount > 0)
        {
            trashCount--; // 垃圾數量減少
            Debug.Log("剩餘 Trash：" + trashCount);
        }

        if (trashCount <= 0)
        {
            Debug.Log("所有垃圾已被清除！");
            if (victoryPanel != null)
            {
                victoryPanel.SetActive(true); // 顯示 UI
            }
        }
    }

}
