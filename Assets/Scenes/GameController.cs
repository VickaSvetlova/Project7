using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private string[] PyramidTypeWound = { "Scratch ", "Slight wound ", "Middle wound ", "Deadly wound " };
    private int[,] PyramidLife = { { 1, 1, 1, 1 }, { 1, 1, 1, 2 }, { 1, 1, 2, 2 }, { 1, 2, 2, 2 } };
    private int[] Damagerange = { 2, 10, 15, 30 };
    private float _damageCount;
    private int numPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TestDamage();
        }
    }
    private void TestDamage()
    {
        for (int i = 0; i < PyramidTypeWound.Length; i++)
        {

            if (RandomNum() >= Damagerange[i])
            {
                for (int j = 0; j < Damagerange.Length; j++)
                {
                    if (PyramidLife[i, j] == 1)
                    {
                        PyramidLife[i, j] = 0;
                        //Debug.Log("You get a " + PyramidTypeWound[i]);
                        break;                     
                    }
                }
            }
        }
        PyramidDebug();
    }

    private int RandomNum()
    {
        int random = 2;//Random.Range(1, 1);
        return random;
    }

    private void PyramidDebug()
    {
        for (int i = 0; i < PyramidTypeWound.Length; i++)
        {
            numPoint = 0;
            for (int j = 0; j < Damagerange.Length; j++)
            {
                if (PyramidLife[i, j] == 1)
                {
                    numPoint += 1;
                }
            }
            Debug.Log(PyramidTypeWound[i] + " " + numPoint);
        }
    }
}
