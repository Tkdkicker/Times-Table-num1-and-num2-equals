namespace Times_Table_num1_and_num2_equals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OperatorList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            string operatorChoice;

            number1 = int.Parse(txtNum1.Text);
            number2 = int.Parse(txtNum2.Text);
            operatorChoice = OperatorList.Text;

            switch (operatorChoice)
            {
                case "+":
                    txtAnswer.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    txtAnswer.Text = (number1 - number2).ToString();
                    break;
                case "/":
                    txtAnswer.Text = (number1 / number2).ToString();
                    break;
                case "X":
                    txtAnswer.Text = (number1 * number2).ToString();
                    break;
            }
        }
    }
}