using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookStore
{
    internal class clsGeneral
    {
        public static string getConnectionString()
        {
            string ConnectionString = @"Data Source=azam-lt\sql19;Initial Catalog=bookstore;User ID=sa;Password=sasasa-1;MultipleActiveResultSets=True";

            return ConnectionString;
        }
        //-------------------------------------------------- Clear Fuction ----------------------------------------------------------------------
        public static void ClearAllInputs(Control Container)
        {
            foreach (Control cc in Container.Controls)
            {
                if (cc is TextBox) //---TextBox---
                {
                    (cc as TextBox).Text = "";
                }
                if (cc is MaskedTextBox) //---MaskedTextBox---
                {
                    (cc as MaskedTextBox).Text = "";
                }
                if (cc is Label) //---Label---
                {
                    if ((cc as Label).BackColor == Color.White)
                    {
                        if ((cc as Label).TextAlign == ContentAlignment.MiddleRight)
                        {
                            (cc as Label).Text = "0";
                        }
                        else
                        {
                            (cc as Label).Text = "";
                        }
                    }
                }
                if (cc is CheckBox) //---CheckBox---
                {
                    (cc as CheckBox).Checked = false;
                }
                if (cc is RadioButton) //---RadioButton---
                {
                    (cc as RadioButton).Checked = false;
                }


                //if (cc is ComboBox) //---ComboBox---
                //{
                //    (cc as ComboBox).Items.Clear();
                //}
            }
        }
    }
}
