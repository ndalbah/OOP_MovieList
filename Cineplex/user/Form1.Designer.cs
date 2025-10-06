namespace Cineplex
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxCode = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxTitle = new TextBox();
            labelFilmCode = new Label();
            comboBoxLanguage = new ComboBox();
            comboBoxCategory = new ComboBox();
            textBoxMinutes = new TextBox();
            textBoxHours = new TextBox();
            listBoxCineplexFilms = new ListBox();
            buttonAdd = new Button();
            labelMinutes = new Label();
            labelHours = new Label();
            labelDuration = new Label();
            labelCategory = new Label();
            labelLanguage = new Label();
            labelActor = new Label();
            labelTitle = new Label();
            buttonPRINT = new Button();
            buttonReset = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonSearch = new Button();
            buttonExit = new Button();
            labelRemove = new Label();
            label1 = new Label();
            labelSearch = new Label();
            labelLastName = new Label();
            labelFirstName = new Label();
            textBoxLastName = new TextBox();
            SuspendLayout();
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(84, 36);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(174, 31);
            textBoxCode.TabIndex = 0;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(142, 191);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(174, 31);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(84, 87);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(174, 31);
            textBoxTitle.TabIndex = 2;
            // 
            // labelFilmCode
            // 
            labelFilmCode.AutoSize = true;
            labelFilmCode.BorderStyle = BorderStyle.Fixed3D;
            labelFilmCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFilmCode.Location = new Point(12, 36);
            labelFilmCode.Name = "labelFilmCode";
            labelFilmCode.Size = new Size(57, 27);
            labelFilmCode.TabIndex = 3;
            labelFilmCode.Text = "Code";
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Location = new Point(545, 30);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(182, 33);
            comboBoxLanguage.TabIndex = 6;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(545, 91);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(182, 33);
            comboBoxCategory.TabIndex = 7;
            // 
            // textBoxMinutes
            // 
            textBoxMinutes.Location = new Point(867, 134);
            textBoxMinutes.Name = "textBoxMinutes";
            textBoxMinutes.Size = new Size(174, 31);
            textBoxMinutes.TabIndex = 13;
            // 
            // textBoxHours
            // 
            textBoxHours.Location = new Point(867, 77);
            textBoxHours.Name = "textBoxHours";
            textBoxHours.Size = new Size(174, 31);
            textBoxHours.TabIndex = 14;
            // 
            // listBoxCineplexFilms
            // 
            listBoxCineplexFilms.FormattingEnabled = true;
            listBoxCineplexFilms.ItemHeight = 25;
            listBoxCineplexFilms.Location = new Point(27, 344);
            listBoxCineplexFilms.Name = "listBoxCineplexFilms";
            listBoxCineplexFilms.Size = new Size(438, 229);
            listBoxCineplexFilms.TabIndex = 15;
            listBoxCineplexFilms.SelectedIndexChanged += listBoxCineplexFilms_SelectedIndexChanged_1;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAdd.Location = new Point(42, 279);
            buttonAdd.Margin = new Padding(4, 5, 4, 5);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(107, 47);
            buttonAdd.TabIndex = 16;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelMinutes
            // 
            labelMinutes.AutoSize = true;
            labelMinutes.BorderStyle = BorderStyle.Fixed3D;
            labelMinutes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMinutes.Location = new Point(760, 138);
            labelMinutes.Name = "labelMinutes";
            labelMinutes.Size = new Size(83, 27);
            labelMinutes.TabIndex = 17;
            labelMinutes.Text = "Minutes";
            // 
            // labelHours
            // 
            labelHours.AutoSize = true;
            labelHours.BorderStyle = BorderStyle.Fixed3D;
            labelHours.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHours.Location = new Point(778, 80);
            labelHours.Name = "labelHours";
            labelHours.Size = new Size(65, 27);
            labelHours.TabIndex = 18;
            labelHours.Text = "Hours";
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.BorderStyle = BorderStyle.Fixed3D;
            labelDuration.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDuration.Location = new Point(867, 20);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(129, 27);
            labelDuration.TabIndex = 19;
            labelDuration.Text = "Film Duration";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.BorderStyle = BorderStyle.Fixed3D;
            labelCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCategory.Location = new Point(371, 91);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(132, 27);
            labelCategory.TabIndex = 20;
            labelCategory.Text = "Film Category";
            // 
            // labelLanguage
            // 
            labelLanguage.AutoSize = true;
            labelLanguage.BorderStyle = BorderStyle.Fixed3D;
            labelLanguage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLanguage.Location = new Point(380, 33);
            labelLanguage.Name = "labelLanguage";
            labelLanguage.Size = new Size(97, 27);
            labelLanguage.TabIndex = 21;
            labelLanguage.Text = "Language";
            // 
            // labelActor
            // 
            labelActor.AutoSize = true;
            labelActor.BorderStyle = BorderStyle.Fixed3D;
            labelActor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelActor.Location = new Point(74, 142);
            labelActor.Name = "labelActor";
            labelActor.Size = new Size(109, 27);
            labelActor.TabIndex = 22;
            labelActor.Text = "Main Actor";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BorderStyle = BorderStyle.Fixed3D;
            labelTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(12, 91);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(52, 27);
            labelTitle.TabIndex = 23;
            labelTitle.Text = "Title";
            // 
            // buttonPRINT
            // 
            buttonPRINT.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPRINT.Location = new Point(178, 279);
            buttonPRINT.Margin = new Padding(4, 5, 4, 5);
            buttonPRINT.Name = "buttonPRINT";
            buttonPRINT.Size = new Size(107, 47);
            buttonPRINT.TabIndex = 24;
            buttonPRINT.Text = "PRINT";
            buttonPRINT.UseVisualStyleBackColor = true;
            buttonPRINT.Click += buttonPRINT_Click_1;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReset.Location = new Point(321, 279);
            buttonReset.Margin = new Padding(4, 5, 4, 5);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(111, 47);
            buttonReset.TabIndex = 25;
            buttonReset.Text = "RESET";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click_1;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonDelete.Location = new Point(1004, 379);
            buttonDelete.Margin = new Padding(4, 5, 4, 5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(107, 55);
            buttonDelete.TabIndex = 29;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click_1;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonUpdate.Location = new Point(1004, 322);
            buttonUpdate.Margin = new Padding(4, 5, 4, 5);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(107, 47);
            buttonUpdate.TabIndex = 28;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click_1;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSearch.Location = new Point(1004, 242);
            buttonSearch.Margin = new Padding(4, 5, 4, 5);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(107, 55);
            buttonSearch.TabIndex = 27;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click_1;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(757, 477);
            buttonExit.Margin = new Padding(4, 5, 4, 5);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(111, 73);
            buttonExit.TabIndex = 26;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelRemove
            // 
            labelRemove.BorderStyle = BorderStyle.Fixed3D;
            labelRemove.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelRemove.Location = new Point(545, 388);
            labelRemove.Margin = new Padding(4, 0, 4, 0);
            labelRemove.Name = "labelRemove";
            labelRemove.Size = new Size(451, 42);
            labelRemove.TabIndex = 32;
            labelRemove.Text = "Choose from the listBox a film to DELETE ";
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(545, 328);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(451, 42);
            label1.TabIndex = 31;
            label1.Text = "Choose from the listBox a film to UPDATE: ";
            // 
            // labelSearch
            // 
            labelSearch.BorderStyle = BorderStyle.Fixed3D;
            labelSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelSearch.Location = new Point(647, 252);
            labelSearch.Margin = new Padding(4, 0, 4, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(349, 39);
            labelSearch.TabIndex = 30;
            labelSearch.Text = "Search for a film by title";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.BorderStyle = BorderStyle.Fixed3D;
            labelLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLastName.Location = new Point(12, 242);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(103, 27);
            labelLastName.TabIndex = 33;
            labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.BorderStyle = BorderStyle.Fixed3D;
            labelFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFirstName.Location = new Point(12, 195);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(105, 27);
            labelFirstName.TabIndex = 34;
            labelFirstName.Text = "First Name";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(142, 238);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(174, 31);
            textBoxLastName.TabIndex = 35;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 596);
            Controls.Add(textBoxLastName);
            Controls.Add(labelFirstName);
            Controls.Add(labelLastName);
            Controls.Add(labelRemove);
            Controls.Add(label1);
            Controls.Add(labelSearch);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonSearch);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(buttonPRINT);
            Controls.Add(labelTitle);
            Controls.Add(labelActor);
            Controls.Add(labelLanguage);
            Controls.Add(labelCategory);
            Controls.Add(labelDuration);
            Controls.Add(labelHours);
            Controls.Add(labelMinutes);
            Controls.Add(buttonAdd);
            Controls.Add(listBoxCineplexFilms);
            Controls.Add(textBoxHours);
            Controls.Add(textBoxMinutes);
            Controls.Add(comboBoxCategory);
            Controls.Add(comboBoxLanguage);
            Controls.Add(labelFilmCode);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxCode);
            Name = "Form1";
            Text = "Noah Dalbah 2333960";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCode;
        private TextBox textBoxFirstName;
        private TextBox textBoxTitle;
        private Label labelFilmCode;
        private ComboBox comboBoxLanguage;
        private ComboBox comboBoxCategory;
        private TextBox textBoxMinutes;
        private TextBox textBoxHours;
        private ListBox listBoxCineplexFilms;
        private Button buttonAdd;
        private Label labelMinutes;
        private Label labelHours;
        private Label labelDuration;
        private Label labelCategory;
        private Label labelLanguage;
        private Label labelActor;
        private Label labelTitle;
        private Button buttonPRINT;
        private Button buttonReset;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonSearch;
        private Button buttonExit;
        private Label labelRemove;
        private Label label1;
        private Label labelSearch;
        private Label labelLastName;
        private Label labelFirstName;
        private TextBox textBoxLastName;
    }
}
