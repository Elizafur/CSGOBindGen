using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSGO_Buy_Bind_Generator
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        string weapon = "";
        string key = "";
        string output = "";

        //Weapon buttons
        private void btnAK_Click(object sender, EventArgs e)
        {
            weapon = "ak47";
            updateWeaponButtons(btnAK);
        }

        private void btnAWP_Click(object sender, EventArgs e)
        {
            weapon = "awp";
            updateWeaponButtons(btnAWP);
        }
        private void btnAUG_Click(object sender, EventArgs e)
        {
            weapon = "aug";
            updateWeaponButtons(btnAUG);
        }

        private void btnCZ_Click(object sender, EventArgs e)
        {
            weapon = "fn57";
            updateWeaponButtons(btnCZ);
        }

        private void btnArmor_Click(object sender, EventArgs e)
        {
            weapon = "vesthelm";
            updateWeaponButtons(btnArmor);
        }

        private void btnDefuser_Click(object sender, EventArgs e)
        {
            weapon = "defuser";
            updateWeaponButtons(btnDefuser);
        }

        private void btnFAMAS_Click(object sender, EventArgs e)
        {
            weapon = "famas";
            updateWeaponButtons(btnFAMAS);
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            weapon = "scar20";
            updateWeaponButtons(btnAuto);
        }

        private void btnDeag_Click(object sender, EventArgs e)
        {
            weapon = "deagle";
            updateWeaponButtons(btnDeag);
        }

        private void btnP250_Click(object sender, EventArgs e)
        {
            weapon = "p250";
            updateWeaponButtons(btnP250);
        }

        private void btnKev_Click(object sender, EventArgs e)
        {
            weapon = "vest";
            updateWeaponButtons(btnKev);
        }

        private void btnZeus_Click(object sender, EventArgs e)
        {
            weapon = "Taser";
            updateWeaponButtons(btnZeus);
        }

        private void btnMag_Click(object sender, EventArgs e)
        {
            weapon = "mag7";
            updateWeaponButtons(btnMag);
        }

        private void btnScout_Click(object sender, EventArgs e)
        {
            weapon = "ssg08";
            updateWeaponButtons(btnScout);
        }


        private void btnFlash_Click(object sender, EventArgs e)
        {
            weapon = "flashbang";
            updateWeaponButtons(btnFlash);
        }

        private void btnSmoke_Click(object sender, EventArgs e)
        {
            weapon = "smokegrenade";
            updateWeaponButtons(btnSmoke);
        }

        private void btnDecoy_Click(object sender, EventArgs e)
        {
            weapon = "decoy";
            updateWeaponButtons(btnDecoy);
        }

        private void btnHE_Click(object sender, EventArgs e)
        {
            weapon = "hegrenade";
            updateWeaponButtons(btnHE);
        }
        private void btnIncen_Click(object sender, EventArgs e)
        {
            weapon = "incgrenade";
            updateWeaponButtons(btnIncen);
        }
        //Weapon buttons

        //Numpad buttons

        //0, .
        private void btnDot_Click(object sender, EventArgs e)
        {
            key = "KP_DEL";
            updateBindButtons(btnDot);
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            key = "KP_INS";
            updateBindButtons(btn0);
        }
        //0, .

        //1, 2, 3
        private void btn1_Click(object sender, EventArgs e)
        {
            key = "KP_END";
            updateBindButtons(btn1);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            key = "KP_DOWNARROW";
            updateBindButtons(btn2);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            key = "KP_PGDN";
            updateBindButtons(btn3);
        }
        //1, 2, 3

        //4, 5, 6
        private void btn4_Click(object sender, EventArgs e)
        {
            key = "KP_LEFTARROW";
            updateBindButtons(btn4);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            key = "KP_5";
            updateBindButtons(btn5);
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            key = "KP_RIGHTARROW";
            updateBindButtons(btn6);
        }
        //4, 5, 6

        //7, 8 ,9
        private void btn7_Click(object sender, EventArgs e)
        {
            key = "KP_HOME";
            updateBindButtons(btn7);
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            key = "KP_UPARROW";
            updateBindButtons(btn8);
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            key = "KP_PGUP";
            updateBindButtons(btn9);
        }
        //7, 8 ,9

        // "/", *, -
        private void btnSlash_Click(object sender, EventArgs e)
        {
            key = "KP_SLASH";
            updateBindButtons(btnSlash);
        }
        private void btnAsterik_Click(object sender, EventArgs e)
        {
            key = "KP_MULTIPLY";
            updateBindButtons(btnAsterik);
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            key = "KP_MINUS";
            updateBindButtons(btnMinus);
        }
        // "/", *, -

        // +, Enter
        private void btnPlus_Click(object sender, EventArgs e)
        {
            key = "KP_PLUS";
            updateBindButtons(btnPlus);
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            key = "KP_ENTER";
            updateBindButtons(btnEnter);
        }
        // +, Enter

        //Numpad buttons

        private void displayOutput()
        {
            if (key != "" && weapon != "")
            {
                output = "bind \"" + key + "\"" + " \"buy " + weapon + "\";";

                //Sets up an array to use incase we need to replace an already written value.
                string[] oldLines = txtOutput.Lines;
                for (int replaceStrings = 0; replaceStrings < oldLines.Length - 1; replaceStrings++)
                {
                    oldLines[replaceStrings] = oldLines[replaceStrings] + "\r\n";
                }

                bool replaced = false;
                for (int i = 0; i < txtOutput.Lines.Length; i++)
                {
                    //Checks if we are replacing an already written value and if we are then we set it correctly in our new array.
                    if (txtOutput.Lines[i].StartsWith("bind \"" + key + "\""))
                    {
                        oldLines[i] = "bind \"" + key + "\"" + " \"buy " + weapon + "\";\r\n";
                        replaced = true;
                    }
                }

                if (replaced)
                {
                    //If we are replacing then we rewrite the text to include all the lines of our new array. We also display an error message.
                    txtOutput.Text = oldLines[0];
                    for (int j = 1; j < oldLines.Length; j++)
                    {
                        txtOutput.Text = txtOutput.Text + oldLines[j];
                    }
                    throwError("Error: " + key + " is already bound!\nRebound " + key + " to buy \'" + weapon + "\'");
                }
                else
                {
                    txtOutput.Text = txtOutput.Text + "" + output + "\r\n";
                }
            }
            else
            {
                if (key == "" && weapon != "") { throwError("Error: key not selected."); }
                else if (weapon == "" && key != "") { throwError("Error: weapon not selected."); }
                else { throwError("Error: weapon and key not selected."); }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            displayOutput();
            resetWeaponButtons();
            resetBindButtons();
            weapon = "";
            key = "";
        }

        private void resetWeaponButtons()
        {
            btnAK.BackColor         = Color.White;
            btnAWP.BackColor        = Color.White;
            btnCZ.BackColor         = Color.White;
            btnArmor.BackColor      = Color.White;
            btnDefuser.BackColor    = Color.White;
            btnFAMAS.BackColor      = Color.White;
            btnAUG.BackColor        = Color.White;
            btnAuto.BackColor       = Color.White;
            btnDeag.BackColor       = Color.White;
            btnP250.BackColor       = Color.White;
            btnKev.BackColor        = Color.White;
            btnZeus.BackColor       = Color.White;
            btnMag.BackColor        = Color.White;
            btnScout.BackColor      = Color.White;
            btnFlash.BackColor      = Color.White;
            btnSmoke.BackColor      = Color.White;
            btnHE.BackColor         = Color.White;
            btnDecoy.BackColor      = Color.White;
            btnIncen.BackColor      = Color.White;
        }

        private void updateWeaponButtons(object sender)
        {
            resetWeaponButtons();
            Button clicked = (Button)sender;
            clicked.BackColor = Color.Green;
        }

        private void resetBindButtons()
        {
            btnDot.BackColor        = Color.White;
            btn0.BackColor          = Color.White;
            btn1.BackColor          = Color.White;
            btn2.BackColor          = Color.White;
            btn3.BackColor          = Color.White;
            btn4.BackColor          = Color.White;
            btn5.BackColor          = Color.White;
            btn6.BackColor          = Color.White;
            btn7.BackColor          = Color.White;
            btn8.BackColor          = Color.White;
            btn9.BackColor          = Color.White;
            btnSlash.BackColor      = Color.White;
            btnAsterik.BackColor    = Color.White;
            btnMinus.BackColor      = Color.White;
            btnPlus.BackColor       = Color.White;
            btnEnter.BackColor      = Color.White;
        }

        private void updateBindButtons(object sender)
        {
            resetBindButtons();
            Button clicked = (Button)sender;
            clicked.BackColor = Color.Blue;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                var newLines = new List<string>(txtOutput.Lines);
                newLines.RemoveAt(0);
                newLines.RemoveAt(0);
                newLines.RemoveAt(newLines.Count - 1);
                string newText = newLines[0];

                for (int i = 1; i < newLines.Count; i++)
                {
                    newText = newText + newLines[i];
                }

                Clipboard.SetText(newText);
                throwError("Output copied to clipboard!");
            }
            catch
            {
                throwError("Error: nothing to copy!");
            }
        }

        private void Menu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0)          { key = "KP_INS"; updateBindButtons(btn0); }
            else if (e.KeyCode == Keys.NumPad1)     { key = "KP_END"; updateBindButtons(btn1); }
            else if (e.KeyCode == Keys.NumPad2)     { key = "KP_DOWNARROW"; updateBindButtons(btn2); }
            else if (e.KeyCode == Keys.NumPad3)     { key = "KP_PGDN"; updateBindButtons(btn3); }
            else if (e.KeyCode == Keys.NumPad4)     { key = "KP_LEFTARROW"; updateBindButtons(btn4); }
            else if (e.KeyCode == Keys.NumPad5)     { key = "KP_5"; updateBindButtons(btn5); }
            else if (e.KeyCode == Keys.NumPad6)     { key = "KP_RIGHTARROW"; updateBindButtons(btn6); }
            else if (e.KeyCode == Keys.NumPad7)     { key = "KP_HOME"; updateBindButtons(btn7); }
            else if (e.KeyCode == Keys.NumPad8)     { key = "KP_UPARROW"; updateBindButtons(btn8); }
            else if (e.KeyCode == Keys.NumPad9)     { key = "KP_PGUP"; updateBindButtons(btn9); }

            else if (e.KeyCode == Keys.Multiply)    { key = "KP_MULTIPLY"; updateBindButtons(btnAsterik); } // *
            else if (e.KeyCode == Keys.Add)         { key = "KP_PLUS"; updateBindButtons(btnPlus); }
            else if (e.KeyCode == Keys.Subtract)    { key = "KP_MINUS"; updateBindButtons(btnMinus); }
            else if (e.KeyCode == Keys.Divide)      { key = "KP_SLASH"; updateBindButtons(btnSlash); } // '/'
            else if (e.KeyCode == Keys.Enter)       { key = "KP_ENTER"; updateBindButtons(btnEnter); } // ENTER
            //For KP_DEL we use KeyPress below.
        }

        private void Menu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')                   { key = "KP_DEL"; updateBindButtons(btnDot); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = "Output\n-----------\n";
        }

        private void throwError(string message)
        {
            lblError.Text = message;
        }
        
    }
}
