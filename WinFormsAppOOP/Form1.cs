namespace WinFormsAppOOP
{

    public partial class PersonForm : Form
    {

        private Person person;

        public PersonForm()
        {

            InitializeComponent();

            person = new PersonModel("PersonModel");

            personName.addPerson(person);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            person.setName(textBox1.Text);

        }

    }

}
