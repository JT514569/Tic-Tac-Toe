using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

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

    public void BTNText1_Click()
    {
        if (BTNText1.text == "")
        {

            if (checker == false)
            {
                BTNText1.text = "X";
                checker = true;
            }
            else
            {
                BTNText1.text = "O";
                checker = false;
            }
            score();
        }

    }

    public void BTNText2_Click()
    {
        if (BTNText2.text == "")
        {

            if (checker == false)
            {
                BTNText2.text = "X";
                checker = true;
            }
            else
            {
                BTNText2.text = "O";
                checker = false;
            }
            score();
        }

    }

    public void BTNText3_Click()
    {
        if (BTNText3.text == "")
        {

            if (checker == false)
            {
                BTNText3.text = "X";
                checker = true;
            }
            else
            {
                BTNText3.text = "O";
                checker = false;
            }
            score();
        }

    }

    public void BTNText4_Click()
    {
        if (BTNText4.text == "")
        {

            if (checker == false)
            {
                BTNText4.text = "X";
                checker = true;
            }
            else
            {
                BTNText4.text = "O";
                checker = false;
            }
            score();
        }

    }

    public void BTNText5_Click()
    {
        if (BTNText5.text == "")
        {

            if (checker == false)
            {
                BTNText5.text = "X";
                checker = true;
            }
            else
            {
                BTNText5.text = "O";
                checker = false;
            }
            score();
        }

    }

    public void BTNText6_Click()
    {
        if (BTNText6.text == "")
        {

            if (checker == false)
            {
                BTNText6.text = "X";
                checker = true;
            }
            else
            {
                BTNText6.text = "O";
                checker = false;
            }
            score();
        }

    }

    public void BTNText7_Click()
    {
        if (BTNText7.text == "")
        {

            if (checker == false)
            {
                BTNText7.text = "X";
                checker = true;
            }
            else
            {
                BTNText7.text = "O";
                checker = false;
            }
            score();
        }

    }

    public void BTNText8_Click()
    {
        if (BTNText8.text == "")
        {

            if (checker == false)
            {
                BTNText8.text = "X";
                checker = true;
            }
            else
            {
                BTNText8.text = "O";
                checker = false;
            }
            score();
        }

    }

    public void BTNText9_Click()
    {
        if (BTNText9.text == "")
        {

            if (checker == false)
            {
                BTNText9.text = "X";
                checker = true;
            }
            else
            {
                BTNText9.text = "O";
                checker = false;
            }
            score();
        }

    }


    public void Reset_Click()
    {
        BTNText1.text = "";
        BTNText2.text = "";
        BTNText3.text = "";
        BTNText4.text = "";
        BTNText5.text = "";
        BTNText6.text = "";
        BTNText7.text = "";
        BTNText8.text = "";
        BTNText9.text = "";
        msgFeedback.text = "";

        BTNText1.color = Color.black;
        BTNText2.color = Color.black;
        BTNText3.color = Color.black;
        BTNText4.color = Color.black;
        BTNText5.color = Color.black;
        BTNText6.color = Color.black;
        BTNText7.color = Color.black;
        BTNText8.color = Color.black;
        BTNText9.color = Color.black;
    }

    public void New_Click()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
}
