using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumCheck : MonoBehaviour
{
    public GameObject[] dices;
    public int[] diceNum = { 1, 2, 3, 4, 5, 6 };
    public int number;
    void Start()
    {
        
        for (int i = 0; i <= dices.Length; i++)
        {
            if (dices[i])
            {
                number = i;
                
            }
        }
    }


    IEnumerator DiceChecking()
    {
        yield return new WaitForSeconds(4.0f);

    }

    void Update()
    {
        Debug.Log(dices + "world position is" + transform.position);
    }


}
