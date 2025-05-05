using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrashManager : MonoBehaviour
{
    public static TrashManager Instance; // ��ҼҦ�
    public GameObject victoryPanel; // ��J UI ����

    private int trashCount; // �O���U���ƶq

    private void Awake()
    {
        // �T�O `Instance` �ߤ@�A�קK���������h�� `TrashManager`
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
            Debug.LogError("VictoryPanel �|���]�w�A�Цb Inspector �]�w���I");
        }

        // �p��������Ҧ� "Trash" ����
        trashCount = GameObject.FindGameObjectsWithTag("Trash").Length;
        Debug.Log("��l Trash �ƶq�G" + trashCount);
    }

    public void RemoveTrash()
    {
        if (trashCount > 0)
        {
            trashCount--; // �U���ƶq���
            Debug.Log("�Ѿl Trash�G" + trashCount);
        }

        if (trashCount <= 0)
        {
            Debug.Log("�Ҧ��U���w�Q�M���I");
            if (victoryPanel != null)
            {
                victoryPanel.SetActive(true); // ��� UI
            }
        }
    }

}
