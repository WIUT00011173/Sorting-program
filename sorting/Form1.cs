using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sorting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            var input = tbxSort.Text.Split(" / , ;.".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var numbers = new double[input.Length];
            for(var i = 0; i < input.Length; i++)
            {
                var number = input[i];
                if (isNumeric(number))
                {
                    numbers[i] = Convert.ToDouble(number);
                    
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        swap(ref numbers[j], ref numbers[i]);
                    }
                }
            }
            MessageBox.Show(string.Join(",", numbers));

            //var sort = true;
            //while (sort)
            //{
            //    sort = false;
            //    for (var i = 0; i < numbers.Length - 1; i++)
            //    {
            //        if (numbers[i] > numbers[i + 1])
            //        {
            //            sort = true;
            //            swap(ref numbers[i], ref numbers[i + 1]);
            //        }
            //    }
            //}
            //    MessageBox.Show(string.Join(",", numbers));

        }

        private void swap(ref double a, ref double b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
        private bool isNumeric(string input)
        {
            return double.TryParse(input, out _);
        }
    }
}
