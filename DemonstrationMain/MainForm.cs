namespace DemonstrationMain
{
    public partial class MainForm : Form
    {
        private BinaryNumber aOperand;
        private BinaryNumber bOperand;
        private BinaryNumber result;

        bool ov;
        bool z;

        public MainForm()
        {
            InitializeComponent();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            aOperand = new BinaryNumber(aOperandTextBox.Text);
            bOperand = new BinaryNumber(bOperandTextBox.Text);

            var binaryNumberResult = aOperand.Plus(bOperand);
            result = binaryNumberResult.res;
            ov = binaryNumberResult.ov;
            z = binaryNumberResult.z;

            resultTextBox.Text = result.ToString();
            ovTextBox.Text = ov.ToString();
            zTextBox.Text = z.ToString();
        }

        private void equalityButton_Click(object sender, EventArgs e)
        {
            aOperand = new BinaryNumber(aOperandTextBox.Text);
            bOperand = new BinaryNumber(bOperandTextBox.Text);

            var binaryNumberResult = aOperand.Equality(bOperand);
            result = binaryNumberResult.res;
            ov = binaryNumberResult.ov;
            z = binaryNumberResult.z;

            resultTextBox.Text = result.ToString();
            ovTextBox.Text = ov.ToString();
            zTextBox.Text = z.ToString();
        }
    }
}
