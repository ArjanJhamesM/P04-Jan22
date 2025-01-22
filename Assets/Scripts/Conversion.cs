using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Conversion : MonoBehaviour
{
    private double philippinePeso;
    private double unitedStatesDollarRate = 0.017110453d;
    private double indianRupeeRate = 1.4802132d;
    private double japaneseYenRate = 2.66356d;
    private double britishPoundRate = 0.013845759d;

    public TMP_InputField inputField;
    public TextMeshProUGUI textMeshProUGUI;

    string inputValue;
    double numericValue;

    public void ToDollars()
    {
        inputValue = inputField.text;

        if ((double.TryParse(inputValue, out numericValue)))
        {
            Debug.Log(numericValue);

            philippinePeso = numericValue * unitedStatesDollarRate;
            textMeshProUGUI.text = "USD " + philippinePeso.ToString();
        }
        else
        {
            Debug.LogWarning("Invalid input");
        }
    }

    public void ToRupees()
    {
        inputValue = inputField.text;

        if ((double.TryParse(inputValue, out numericValue)))
        {
            Debug.Log(numericValue);

            philippinePeso = numericValue * indianRupeeRate;
            textMeshProUGUI.text = "INR " + philippinePeso.ToString();
        }
        else
        {
            Debug.LogWarning("Invalid input");
        }
    }

    public void ToYen()
    {
        inputValue = inputField.text;

        if ((double.TryParse(inputValue, out numericValue)))
        {
            Debug.Log(numericValue);

            philippinePeso = numericValue * japaneseYenRate;
            textMeshProUGUI.text = "JPY " + philippinePeso.ToString();
        }
        else
        {
            Debug.LogWarning("Invalid input");
        }
    }

    public void ToPounds()
    {
        inputValue = inputField.text;

        if ((double.TryParse(inputValue, out numericValue)))
        {
            Debug.Log(numericValue);

            philippinePeso = numericValue * britishPoundRate;
            textMeshProUGUI.text = "GBP " + philippinePeso.ToString();
        }
        else
        {
            Debug.LogWarning("Invalid input");
        }
    }
}
