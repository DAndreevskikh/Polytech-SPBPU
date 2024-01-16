namespace PhoneBook
{
    public partial class Form1 : Form
    {

        private int current = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool CheckEnabled()
        {
            return ((txtFerstName.Text != "" || txtLastName.Text != "") &&
                  (txtEmail.Text != "" || txtPhone.Text != ""));

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            SItem temp;
            current--;

            if (Records.GetItem(current, out temp))
            {
                txtLastName.Text = temp.LName;
                txtFerstName.Text = temp.FName;
                txtPhone.Text = (temp.Phone != 0) ? temp.Phone.ToString() : "";
                txtEmail.Text = temp.Email;
                lblCount.Text = "Запись " + current + " из " + Records.GetLength();
            }
            else
            {
                lblCount.Text = "Ошибка";

                btnNext.Enabled = true;
                btnLeft.Enabled = (current > 0);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SItem temp;
            current++;

            if (Records.GetItem(current, out temp))
            {
                txtLastName.Text = temp.LName;
                txtFerstName.Text = temp.FName;
                txtPhone.Text = (temp.Phone != 0) ? temp.Phone.ToString() : "";
                txtEmail.Text = temp.Email;
                lblCount.Text = "Запись " + current + " из " + Records.GetLength();
            }
            else
            {
                txtLastName.Text = "";
                txtFerstName.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
                lblCount.Text = "Новая запись";
            }

            btnLeft.Enabled = (current > 0);
            btnNext.Enabled = (current < Records.GetLength());
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            SItem temp;

            temp.LName = txtLastName.Text;
            temp.FName = txtFerstName.Text;
            temp.Phone = (txtPhone.Text.Length > 0) ? ulong.Parse(txtPhone.Text) : 0;
            temp.Email = txtEmail.Text;

            Records.AddItem(temp);
            btnNext_Click(sender, e);
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

            btnAdd.Enabled = CheckEnabled() && (current == Records.GetLength());
        }
    }
}


