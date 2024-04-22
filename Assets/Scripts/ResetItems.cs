using System.Collections.Generic;
using UnityEngine;

public class ResetItems : MonoBehaviour
{
    [SerializeField] private List<GameObject> _items;

    public void ResetItem()
    {
        foreach (var item in _items)
        {
            item.gameObject.SetActive(true);
        }
    }
}
