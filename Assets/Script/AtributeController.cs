using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtributeController :
    MonoBehaviour
{
    [SerializeField]
    private Text[] _text;
    private int[] AtributeInt = { 4, 3, 2, 1 };
    private int[] DamageRange = { 2, 10, 15, 30 };
    private string[] AtributeString = { "Scratch ", "Slight wound ", "Middle wound ", "Deadly wound " };
    private bool _isHit;
    private int random;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TestDamage();
        }
    }

    private void TestDamage()
    {
        _isHit = false;
        for (int i = 0; i < AtributeInt.Length; i++)
        {
            if (_isHit)
            {
                DebugTest();
                break;
            }
            if (RandomNum() >= DamageRange[i])
            {
                for (int j = 0; j < DamageRange.Length; j++)
                {
                    if (AtributeInt[j] > 0)
                    {
                        AtributeInt[j] -= 1;
                        _text[4].text = "Power hit " + AtributeString[j];
                        _isHit = true;
                        break;
                    }
                }
            }
        }
    }

    private void DebugTest()
    {
        for (int i = 0; i < AtributeInt.Length; i++)
        {
            _text[i].text = AtributeString[i] + " " + AtributeInt[i];
        }
    }

    private int RandomNum()
    {
        int random = 20; //Random.Range(6, 36);
        return random;
    }
}
