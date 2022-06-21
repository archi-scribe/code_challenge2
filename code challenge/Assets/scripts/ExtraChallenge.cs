using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraChallenge : MonoBehaviour
{
    public int firstNumber;
    public int secondNumber;
    private int resultNumber;
    private int randomNumber;


    // Start is called before the first frame update
    void Start()
    {
        firstNumber = Random.Range(0, 10);
        secondNumber = Random.Range(0, 10);
        resultNumber = firstNumber + secondNumber;
        Debug.Log(resultNumber);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            randomNumber = Random.Range(0, 10);
            resultNumber = resultNumber + randomNumber;
            Debug.Log(resultNumber);
	} 
	
	
	   
    }
}
