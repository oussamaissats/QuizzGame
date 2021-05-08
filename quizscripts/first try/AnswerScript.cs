using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class AnswerScript : MonoBehaviour
{

public bool isCorrect = false; 
public QuizManager quizzManager ; 




public void Answer(){


    if (isCorrect)
    {

        Debug.Log("Correct Answer");
        quizzManager.correct();
    }
    else
    {
       Debug.Log("wrong Answer"); 
       quizzManager.correct() ;
    }




}
}
