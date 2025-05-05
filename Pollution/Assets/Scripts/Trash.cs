using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    private void OnDestroy()
    {
        if (TrashManager.Instance != null)
        {
            TrashManager.Instance.RemoveTrash();
        }
    }
}
