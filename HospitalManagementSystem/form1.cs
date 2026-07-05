namespace HospitalManagementSystem
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientLoginFrm patientLoginFrm = new PatientLoginFrm();
            patientLoginFrm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorLoginFrm doctorLoginFrm = new DoctorLoginFrm();
            doctorLoginFrm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SecretaryLogin secretaryLogin = new SecretaryLogin();
            secretaryLogin.Show();
            this.Hide();
        }
    }
}
