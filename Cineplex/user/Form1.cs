using Cineplex.bus;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cineplex
{
    public partial class Form1 : Form
    {
        Film currentFilm;
        Person currentPerson;
        Time currentDuration;

        List<Film> listOfFilms = new List<Film>();


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            currentFilm = new Film();
            currentPerson = new Person();
            currentDuration = new Time();

            int code;
            string? title;

            try
            {
                code = Convert.ToInt32(this.textBoxCode.Text);
                title = this.textBoxTitle.Text;

                currentFilm.Code = code;
                currentFilm.Title = title;

                EnumLanguage currentLanguage;
                Enum.TryParse(this.comboBoxLanguage.Text, out currentLanguage);
                currentFilm.Language = currentLanguage;

                currentPerson.FirstName = this.textBoxFirstName.Text;
                currentPerson.LastName = this.textBoxLastName.Text;

                currentDuration.Hours = Convert.ToInt32(this.textBoxHours.Text);
                currentDuration.Minutes = Convert.ToInt32(this.textBoxMinutes.Text);
                if (currentDuration.Hours < 0 || currentDuration.Hours < 0 || currentDuration.Minutes < 0 || currentDuration.Minutes > 60)
                {
                    MessageBox.Show("Enter a valid time format");
                }
                else
                {
                    currentFilm.Duration = currentDuration;
                }
                

                listOfFilms.Add(currentFilm);
            }
            catch (Exception currentException)
            {
                MessageBox.Show(currentException.Message + "\n\tYou must input valid data");
                this.textBoxCode.Focus();
            }


        }






        int index = -1;
        private void listBoxCineplexFilms_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            index = this.listBoxCineplexFilms.SelectedIndex;

            this.textBoxCode.Text = Convert.ToString(this.listOfFilms[index].Code);

            this.textBoxTitle.Text = this.listOfFilms[index].Title;

            this.comboBoxCategory.Text = Convert.ToString(this.listOfFilms[index].Category);

            this.comboBoxLanguage.Text = Convert.ToString(this.listOfFilms[index].Language);

            this.textBoxFirstName.Text = this.listOfFilms[index].Actor.FirstName;

            this.textBoxLastName.Text = this.listOfFilms[index].Actor.LastName;

            this.textBoxHours.Text = Convert.ToString(this.listOfFilms[index].Duration.Hours);

            this.textBoxMinutes.Text = Convert.ToString(this.listOfFilms[index].Duration.Minutes);
        }


        private void buttonPRINT_Click_1(object sender, EventArgs e)
        {
            if (this.listOfFilms.Count > 0 && this.listBoxCineplexFilms.Items.Count == 0)
            {
                foreach (Film currentFilm in this.listOfFilms)
                {
                    this.listBoxCineplexFilms.Items.Add(currentFilm);
                }

            }

            else
            {
                MessageBox.Show("Films already printed in the listBox OR the list of films in memory is empty");
            }


        }

        private void buttonReset_Click_1(object sender, EventArgs e)
        {
            this.textBoxCode.Text = string.Empty;
            this.textBoxTitle.Text = string.Empty;

            this.textBoxHours.Text = string.Empty;
            this.textBoxMinutes.Text = string.Empty;


            this.textBoxCode.Focus();

            this.listBoxCineplexFilms.Items.Clear();

            this.comboBoxLanguage.Text = Convert.ToString(EnumLanguage.UNDEFINED);
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            bool found = false;
            Film searchedBook = new Film();

            foreach (Film item in this.listOfFilms)
            {
                if (item.Title == this.textBoxTitle.Text)
                {
                    found = true;
                    searchedBook = item;
                    break;
                }
            }

            if (found)
            {
                MessageBox.Show("Film found \n  " + searchedBook.GetFilmState(), "Event programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.listBoxCineplexFilms.Items.Add(searchedBook.GetFilmState());
            }
            else
            {

                MessageBox.Show("Film not found", "Event programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {

            if (index >= 0)
            {
                this.listOfFilms[index].Code = Convert.ToInt32(this.textBoxCode.Text);

                this.listOfFilms[index].Title = this.textBoxTitle.Text;

                EnumLanguage langage;

                Enum.TryParse(this.comboBoxLanguage.Text, out langage);

                this.listOfFilms[index].Language = langage;

                this.currentDuration = new Time();

                this.currentDuration.Hours = Convert.ToInt32(this.textBoxHours.Text); ;

                this.currentDuration.Minutes = Convert.ToInt32(this.textBoxMinutes.Text);

                this.listOfFilms[index].Duration = this.currentDuration;
            }
            else
            {

                MessageBox.Show("You must choose from the listBox a film to update");

            }
            this.listBoxCineplexFilms.Items.Clear();
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                this.listOfFilms.RemoveAt(index);
                MessageBox.Show("The film at the selected index " + index + " is removed from the list of films in memory");
            }
            else
            {
                MessageBox.Show("Choose from the listBox a film to remove");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            foreach (EnumLanguage item in Enum.GetValues(typeof(EnumLanguage)))
            {
                this.comboBoxLanguage.Items.Add(item);
            }

            foreach (EnumCategory item in Enum.GetValues(typeof(EnumCategory)))
            {
                this.comboBoxCategory.Items.Add(item);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application written by Noah Dalbah. Student ID: 2333960", "Event Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
