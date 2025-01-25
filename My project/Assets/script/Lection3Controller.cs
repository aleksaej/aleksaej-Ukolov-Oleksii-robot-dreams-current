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
            Debug.Log("������ �������.");
            return;
        }

        
        string result = string.Join(", ", items);
        Debug.Log("�������� ������: " + result);
    }

    
    [ContextMenu("Add Item")]
    private void AddItem()
    {
        if (!string.IsNullOrWhiteSpace(inputItem))
        {
            items.Add(inputItem);
            Debug.Log($"������� '{inputItem}' ������ �� ������.");
        }
        else
        {
            Debug.Log("���� �������� ������. ������ �������� ��� ���������.");
        }
    }

   
    [ContextMenu("Remove Item")]
    private void RemoveItem()
    {
        if (items.Remove(inputItem))
        {
            Debug.Log($"������� '{inputItem}' ��������.");
        }
        else
        {
            Debug.Log($"������� '{inputItem}' �� ��������.");
        }
    }

    
    [ContextMenu("Clear List")]
    private void ClearList()
    {
        items.Clear();
        Debug.Log("������ �������.");
    }

    
    [ContextMenu("Sort List")]
    private void SortList()
    {
        if (items.Count > 0)
        {
            items.Sort();
            Debug.Log("������ �����������.");
        }
        else
        {
            Debug.Log("���� ���� ���������.");
        }
    }
}