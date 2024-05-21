using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcasestatement
{
    class Program
    {
        static void Main(string[] args)
        {
            private void button1_click(object sender,EventArgs)
    {
                string day;
                day=textbox2.text;
                switch(day)
                {
                    case"monday":
                        textBox1.Text="first day of the week";
                        break;
                        case"Tuesday":
                        textBox1.Text="second day of the week";
                        break;
                        case"Wednesday":
                        textBox1.Text="third day of the week";
                        break;
                        case"Tursday":
                        textBox1.Text="fourth day of the week";
                        break;
                        case"Friday":
                        textBox1.Text="fifth day of the week";
                        break;
                        case"Saturday":
                        textBox1.Text="sixth day of the week";
                        break;
                    case"sunday":
                        textBox1.Text="weekend!!!";
                        break;
                    default:
                        messageBoxButtons.okcancel,messageBoxIcon.Information);
                        break;
        }
     }
            
   }
}

