using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    [SerializeField] private int _firstNumber;
    [SerializeField] private int _secondNumber;
    [ContextMenu("Add")]
    private void Add()
    {
        int result = _firstNumber + _secondNumber;  
        Debug.Log(result); 
    }

}
