using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class AtributeControllerVer1 : MonoBehaviour
{
    #region Enums
    #endregion

    #region Delegates
    public UnityEvent EventHangedGUI;
    #endregion

    #region Structures
    #endregion

    #region Classes
    #endregion

    #region Fields
    [SerializeField]
    private Text[] _text;
    #endregion

    #region Events
    #endregion

    #region Properties
    private int _fundedLoss;
    private int _interDamage;
    private int[] _rangeDamage = { 2, 10, 15, 30 };
    private string[] _nameDamage = { "screch", "lose breat ", "hight breat ", "dedly breat " };
    public int DiceD6 = 1;
    #endregion

    #region Methods
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TestDamage();
        }
    }
    private void TestDamage()
    {
        _interDamage = RandomDice();
        Debug.Log("random " + _interDamage);
        for (int i = 0; i < _rangeDamage.Length; i++)
        {
            if (_interDamage >= _rangeDamage[i])
            {
                Debug.Log(_nameDamage[i]);
                _fundedLoss += _interDamage;
                break;
            }
        }
    }
    /// <summary>
    /// random dice
    /// </summary>
    /// <returns>int</returns>
    private int RandomDice()
    {
        int _random = Random.RandomRange(DiceD6, DiceD6 * 6);
        return _random;
    }
    #endregion

    #region Event Handlers
    #endregion
}
