using System.Data;

namespace day10_winform
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gettext = question_text.Text;
            string[] string_values = gettext.Split("x");
            double a, b, c;
            a = Convert.ToDouble(string_values[0]);
            b = Convert.ToDouble(string_values[1]);
            c = a * b;
            solution_textbox.Text = c.ToString();
            solution_label.Text = c.ToString();
        }
    }
}
