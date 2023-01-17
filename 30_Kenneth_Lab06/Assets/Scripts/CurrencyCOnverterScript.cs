using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyCOnverterScript : MonoBehaviour
{
    //currency converted from sgd
    private float USD = 0.75727f;
    private float JPY = 96.8051f;
    private float RM = 3.08f;
    private float KRW = 881.54f;
    private float TWD = 20.73f;
    private float EUR = 0.63F;

    //gameobjects used for checking and outputting fields
    public InputField inputSGD;
    public Toggle usdToggle;
    public Toggle jpyToggle;
    public Toggle RMToggle;
    public Toggle KRWToggle;
    public Toggle TWDToggle;
    public Toggle EURToggle;
    public InputField outputField;
    public Text outputTitleText;

    //values used for currency converting
    private float sgdAmount;
    private float outputAmount;
    //misc text
    public GameObject errorText;
    private bool errorOccured;
    private string outputTitle;
    // Start is called before the first frame update
    void Start()
    {
        outputTitle = "Value: ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ConvertCurrency()
    {
        try
        {
            sgdAmount = float.Parse(inputSGD.text);
            errorOccured = false;
        }
        catch (FormatException e)
        {
            errorText.SetActive(true);
            errorOccured = true;
        }

        if (usdToggle.isOn)
        {
            outputAmount = sgdAmount * USD;
            outputTitleText.text = outputTitle + "(USD)";
        }
        else if (jpyToggle.isOn)
        {
            outputAmount = sgdAmount * JPY;
            outputTitleText.text = outputTitle + "(JPY)";
        }
        else if (RMToggle.isOn)
        {
            outputAmount = sgdAmount * RM;
            outputTitleText.text = outputTitle + "(RM)";
        }
        else if (KRWToggle.isOn)
        {
            outputAmount = sgdAmount * KRW;
            outputTitleText.text = outputTitle + "(KRW)";
        }
        else if (TWDToggle.isOn)
        {
            outputAmount = sgdAmount * TWD;
            outputTitleText.text = outputTitle + "(TWD)";
        }
        else if (EURToggle.isOn)
        {
            outputAmount = sgdAmount * EUR;
            outputTitleText.text = outputTitle + "(EUR)";
        }

        if (errorOccured == false)
        {
            errorText.SetActive(false);
            outputField.text = outputAmount.ToString();
        }
        else if(errorOccured == true)
        {
            outputField.text = null;
        }
    }

    public void ClearAmounts()
    {
        inputSGD.text = null;
        outputField.text = null;
        errorText.SetActive(false);
        outputTitleText.text = outputTitle;
    }
}
