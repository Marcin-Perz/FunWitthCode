using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunWithCodeWinForms
{
    public partial class RectanglesRandomFill : Form
    {
        public RectanglesRandomFill()
        {
            InitializeComponent();
        }
            Size horizontal = new Size(7, 28);
            Size vertical = new Size(28, 7);

        private void buttonRandomFill_Click(object sender, EventArgs e)
        {
            Random random1 = new Random();
            Size randSize = random1.Next(2) == 1 ? horizontal : vertical;
            int id = 0;
            int[,] resultArray = new int[200, 200];


     
            for (int i = 0; i < 500; i++)
            {
                for (int k = 0; k < 500; k++)
                {
                    int rand = random1.Next(2);
                    if (rand ==1)
                    {
                        CheckIfFreeOrSame(resultArray[i, k + 1]);
                        if ((resultArray.GetUpperBound(1) - horizontal.Width) >= horizontal.Width)
                        {
                            for (int n = 0; n < horizontal.Width; n++)
                            {
                                resultArray[i, k + n] =id;

                            }
                        };
                    }
                    else
                    {

                    }


                }



            }
        }

        private static bool CheckIfFreeOrSame( int toCheck, int qualifaier=0)
        {
            if (toCheck == qualifaier && toCheck == 0) return true;
            return false;
        }
    }
}
