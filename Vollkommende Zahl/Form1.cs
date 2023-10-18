namespace Vollkommende_Zahl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            //def strings
            string output_string = "";
            string solve_string = "";
            string input_string = "";
            input_string = input_txtbox.Text;
            solve_string = solve_label.Text;
            output_string = output_label.Text;
            Int64 input_int = 0;

            //formating into int
            try
            {
                input_int = Convert.ToInt32(input_string);
            }
            catch (FormatException)
            {
                //wrong formations
                MessageBox.Show("FormatException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (OverflowException)
            {
                //to huge for Int32
                MessageBox.Show("OverflowException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //check int is higher as 0 or lower as 100000
            if (input_int > 0 && input_int < 100001)
            {
                //calc for Vollkommenheit
                //List for dividers
                List<int> teiler = new List<int>();
                for (int i = 1; i <= (input_int / 2); i++)
                {
                    if (input_int % i == 0)
                    {
                        teiler.Add(i);
                    }
                }
                int result = 0;

                //adding to equale a item
                foreach (int item in teiler)
                {
                    result += item;
                }
                //reset the output
                output_string = "";
                output_label.Text = output_string;
                //create true string
                if (result == input_int)
                {
                    solve_string = (input_int + " ist eine vollkommene Zahl.\nDie Teiler : ");
                    foreach (int item in teiler)
                    {
                        output_string += String.Join(",", item + ",");
                    }

                }

                //create false string
                else
                {
                    solve_string = (input_int + " ist keine vollkommene Zahl.");
                    output_string = "";
                }

                // Display Data
                solve_label.Text = solve_string;
                output_string.RemoveLast(",");
                output_label.Text = output_string;
            }
            else
            {
                // if value to high or low
                MessageBox.Show("Number is higher as 100.000 or low/is as 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            //def strings for reset
            string output_string;
            string solve_string;
            string input_string;

            //question dialog
            if (MessageBox.Show("Wollen Sie alles zurücksetzten? (Wiederherstellung nicht möglich)", "Zurücksetzen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // reset strings
                output_string = "";
                solve_string = "Es wurde noch keine Eingabe gemacht";
                input_string = "";

                //display strings
                input_txtbox.Text = input_string;
                solve_label.Text = solve_string;
                output_label.Text = output_string;
                listboxResults.Items.Clear();
            }
            else
            {
                // if the user declined
            }
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            //create an aboutbox
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            //close func
            if (MessageBox.Show("Wollen Sie jetzt beenden?", "Beenden?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            { Close(); }

        }

        private void input_txtbox_enter(object sender, KeyPressEventArgs e)
        {
            //not used or i forgót it
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chck_btn_Click(object sender, EventArgs e)
        {

            string solve_string = "";
            string input_string = "";
            listboxResults.Items.Clear();
            string endstring;
            Int64 input_int = 1;

            while (input_int < 10001)
            {
                string output_string = "";
                //calc for Vollkommenheit
                //List for dividers
                List<int> teiler = new List<int>();
                for (int i = 1; i <= (input_int / 2); i++)
                {
                    if (input_int % i == 0)
                    {
                        teiler.Add(i);
                    }
                }
                int result = 0;

                //adding to equale a item
                foreach (int item in teiler)
                {
                    result += item;
                }
                //create true string
                if (result == input_int)
                {
                    solve_string = (input_int + " ist eine vollkommene Zahl.\nDie Teiler : ");
                    foreach (int item in teiler)
                    {
                        output_string += String.Join(",", item + ",");
                    }
                    endstring = $"{input_int} ist eine vollkommene Zahl.\nDie Teiler : {output_string}";
                    listboxResults.Items.Add(endstring);
                    MessageBox.Show($"{input_int} ist eine vollkommene Zahl.\nDie Teiler : {output_string}", "Test bis 10.000", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (input_int == 10000)
                {
                    MessageBox.Show("10.000 erreicht", "Test bis 10.000", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                input_int++;
            }

        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Joke", ".", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listoxResults_hover(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}