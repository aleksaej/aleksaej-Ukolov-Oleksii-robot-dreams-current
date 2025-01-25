using System.Collections.Generic;
using UnityEngine;

public class ListController : MonoBehaviour
{
    
    private List<string> items = new List<string>();

    
    [SerializeField]
    private string inputItem;

    
    [ContextMenu("Print List")]
    private void PrintList()
    {
        if (items.Count == 0)
        {
            Debug.Log("Список порожній.");
            return;
        }

        
        string result = string.Join(", ", items);
        Debug.Log("Елементи списку: " + result);
    }

    
    [ContextMenu("Add Item")]
    private void AddItem()
    {
        if (!string.IsNullOrWhiteSpace(inputItem))
        {
            items.Add(inputItem);
            Debug.Log($"Елемент '{inputItem}' додано до списку.");
        }
        else
        {
            Debug.Log("Поле введення порожнє. Введіть значення для додавання.");
        }
    }

   
    [ContextMenu("Remove Item")]
    private void RemoveItem()
    {
        if (items.Remove(inputItem))
        {
            Debug.Log($"Елемент '{inputItem}' видалено.");
        }
        else
        {
            Debug.Log($"Елемент '{inputItem}' не знайдено.");
        }
    }

    
    [ContextMenu("Clear List")]
    private void ClearList()
    {
        items.Clear();
        Debug.Log("Список очищено.");
    }

    
    [ContextMenu("Sort List")]
    private void SortList()
    {
        if (items.Count > 0)
        {
            items.Sort();
            Debug.Log("Список відсортовано.");
        }
        else
        {
            Debug.Log("Немає чого сортувати.");
        }
    }
}