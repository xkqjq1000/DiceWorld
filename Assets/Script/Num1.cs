using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Num1 : MonoBehaviour
{
    public int i1 = 1;
        Dice dice;

    private void Start()
    {
        NUM1();
    }
    public void NUM1()
    {

        if (this.gameObject.transform.position.y > dice.gameObject.transform.position.y)
        {
            Debug.Log(1);
        }
    }
}
