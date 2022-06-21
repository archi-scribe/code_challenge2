using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeChallenge : MonoBehaviour
{
    public int firstNumber;
    public int secondNumber;
    private int resultNumber;
        

    // Start is called before the first frame update
    void Start()
    {

        resultNumber = firstNumber + secondNumber;
        Debug.Log(resultNumber);   
	
	   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
