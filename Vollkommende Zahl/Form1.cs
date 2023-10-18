namespace Vollkommende_Zahl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            //formating input to int
            string output_string = "";
            string solve_string = "";
            string input_string = "";
            input_string = input_txtbox.Text;
            solve_string = solve_label.Text;
            output_string = output_label.Text;
            Int64 input_int = 0;

            try
            {
                input_int = Convert.ToInt32(input_string);
            }
            catch (FormatException)
            {
                MessageBox.Show("FormatException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("OverflowException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //check int is higher as 0 or lower as 10000
            if (input_int > 0 && input_int < 10001)
            {
                List<int> teiler = new List<int>();
                for (int i = 1; i <= (input_int / 2); i++)
                {
                    if (input_int % i == 0)
                    {
                        teiler.Add(i);
                    }
                }
                int result = 0;
                foreach (int item in teiler)
                {
                    result += item;
                }

                if (result == input_int)
                {
                    solve_string = (input_int + " ist eine vollkommene Zahl.\nDie Teiler : ");
                    foreach (int item in teiler)
                    {
                        output_string += String.Join(", ", ", " + item);
                    }
                }
                else
                {
                    solve_string = (input_int + " ist keine vollkommene Zahl.");
                    output_string = "";
                }
                solve_label.Text = solve_string;
                output_label.Text = output_string;
            }
            else
            {
                MessageBox.Show("Number is higher as 10.000 or low/is as 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            string output_string;
            string solve_string;
            string input_string;

            if (MessageBox.Show("Wollen Sie alles zurücksetzten? (Wiederherstellung nicht möglich)", "Zurücksetzen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                output_string = "";
                solve_string = "Es wurde noch keine Eingabe gemacht";
                input_string = "";

                input_txtbox.Text = input_string;
                solve_label.Text = solve_string;
                output_label.Text = output_string;
            }
            else
            {

            }
        }
    }
}