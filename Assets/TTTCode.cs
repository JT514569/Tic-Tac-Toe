using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TTTCode : MonoBehaviour
{
    bool checker;
    int plusone;

    public Text BTNText1 = null;
    public Text BTNText2 = null;
    public Text BTNText3 = null;
    public Text BTNText4 = null;
    public Text BTNText5 = null;
    public Text BTNText6 = null;
    public Text BTNText7 = null;
    public Text BTNText8 = null;
    public Text BTNText9 = null;

    public Text Reset = null;
    public Text New = null;
    public Text msgFeedback = null;

    public Text PlayerX;
    public Text PlayerO;

    public void score()
    {
        if (BTNText1.text == "X" && BTNText2.text == "X" && BTNText3.text == "X")
        {
            BTNText1.color = Color.red;
            BTNText2.color = Color.red;
            BTNText3.color = Color.red;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(PlayerX.text);
            PlayerX.text = Convert.ToString(plusone + 1);
        }

        if (BTNText1.text == "X" && BTNText4.text == "X" && BTNText7.text == "X")
        {
            BTNText1.color = Color.blue;
            BTNText4.color = Color.blue;
            BTNText7.color = Color.blue;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(PlayerX.text);
            PlayerX.text = Convert.ToString(plusone + 1);
        }

        if (BTNText1.text == "X" && BTNText5.text == "X" && BTNText9.text == "X")
        {
            BTNText1.color = Color.green;
            BTNText5.color = Color.green;
            BTNText9.color = Color.green;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(PlayerX.text);
            PlayerX.text = Convert.ToString(plusone + 1);
        }

        if (BTNText3.text == "X" && BTNText5.text == "X" && BTNText7.text == "X")
        {
            BTNText3.color = Color.gray;
            BTNText5.color = Color.gray;
            BTNText7.color = Color.gray;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(PlayerX.text);
            PlayerX.text = Convert.ToString(plusone + 1);
        }

        if (BTNText2.text == "X" && BTNText5.text == "X" && BTNText8.text == "X")
        {
            BTNText2.color = Color.yellow;
            BTNText5.color = Color.yellow;
            BTNText8.color = Color.yellow;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(PlayerX.text);
            PlayerX.text = Convert.ToString(plusone + 1);
        }

        if (BTNText3.text == "X" && BTNText6.text == "X" && BTNText9.text == "X")
        {
            BTNText3.color = Color.cyan;
            BTNText6.color = Color.cyan;
            BTNText9.color = Color.cyan;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(PlayerX.text);
            PlayerX.text = Convert.ToString(plusone + 1);
        }

        if (BTNText4.text == "X" && BTNText5.text == "X" && BTNText6.text == "X")
        {
            BTNText4.color = Color.green;
            BTNText5.color = Color.green;
            BTNText6.color = Color.green;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(PlayerX.text);
            PlayerX.text = Convert.ToString(plusone + 1);
        }

        if (BTNText7.text == "X" && BTNText8.text == "X" && BTNText9.text == "X")
        {
            BTNText7.color = Color.blue;
            BTNText8.color = Color.blue;
            BTNText9.color = Color.blue;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(PlayerX.text);
            PlayerX.text = Convert.ToString(plusone + 1);
        }

        //===================================================PlayerO=============================================================

        if (BTNText1.text == "O" && BTNText2.text == "O" && BTNText3.text == "O")
        {
            BTNText1.color = Color.red;
            BTNText2.color = Color.red;
            BTNText3.color = Color.red;
            msgFeedback.text = "The Winner is PlayerO";
            plusone = int.Parse(PlayerO.text);
            PlayerO.text = Convert.ToString(plusone + 1);
        }

        if (BTNText1.text == "O" && BTNText4.text == "O" && BTNText7.text == "O")
        {
            BTNText1.color = Color.blue;
            BTNText4.color = Color.blue;
            BTNText7.color = Color.blue;
            msgFeedback.text = "The Winner is PlayerO";
            plusone = int.Parse(PlayerO.text);
            PlayerO.text = Convert.ToString(plusone + 1);
        }

        if (BTNText1.text == "O" && BTNText5.text == "O" && BTNText9.text == "O")
        {
            BTNText1.color = Color.green;
            BTNText5.color = Color.green;
            BTNText9.color = Color.green;
            msgFeedback.text = "The Winner is PlayerO";
            plusone = int.Parse(PlayerO.text);
            PlayerO.text = Convert.ToString(plusone + 1);
        }

        if (BTNText3.text == "O" && BTNText5.text == "O" && BTNText7.text == "O")
        {
            BTNText3.color = Color.gray;
            BTNText5.color = Color.gray;
            BTNText7.color = Color.gray;
            msgFeedback.text = "The Winner is PlayerO";
            plusone = int.Parse(PlayerO.text);
            PlayerO.text = Convert.ToString(plusone + 1);
        }

        if (BTNText2.text == "O" && BTNText5.text == "O" && BTNText8.text == "O")
        {
            BTNText2.color = Color.yellow;
            BTNText5.color = Color.yellow;
            BTNText8.color = Color.yellow;
            msgFeedback.text = "The Winner is PlayerO";
            plusone = int.Parse(PlayerO.text);
            PlayerO.text = Convert.ToString(plusone + 1);
        }

        if (BTNText3.text == "O" && BTNText6.text == "O" && BTNText9.text == "O")
        {
            BTNText3.color = Color.cyan;
            BTNText6.color = Color.cyan;
            BTNText9.color = Color.cyan;
            msgFeedback.text = "The Winner is PlayerO";
            plusone = int.Parse(PlayerO.text);
            PlayerO.text = Convert.ToString(plusone + 1);
        }

        if (BTNText4.text == "O" && BTNText5.text == "O" && BTNText6.text == "O")
        {
            BTNText4.color = Color.green;
            BTNText5.color = Color.green;
            BTNText6.color = Color.green;
            msgFeedback.text = "The Winner is PlayerO";
            plusone = int.Parse(PlayerO.text);
            PlayerO.text = Convert.ToString(plusone + 1);
        }

        if (BTNText7.text == "O" && BTNText8.text == "O" && BTNText9.text == "O")
        {
            BTNText7.color = Color.blue;
            BTNText8.color = Color.blue;
            BTNText9.color = Color.blue;
            msgFeedback.text = "The Winner is PlayerO";
            plusone = int.Parse(PlayerO.text);
            PlayerO.text = Convert.ToString(plusone + 1);
        }
    }
}
