namespace Ex12
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadFilesButton = new System.Windows.Forms.Button();
            this.xmlLabel = new System.Windows.Forms.Label();
            this.xsdLabel = new System.Windows.Forms.Label();
            this.validationButton = new System.Windows.Forms.Button();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.allDaysRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sundayRadioButton = new System.Windows.Forms.RadioButton();
            this.saturdayRadioButton = new System.Windows.Forms.RadioButton();
            this.fridayRadioButton = new System.Windows.Forms.RadioButton();
            this.thursdayRadioButton = new System.Windows.Forms.RadioButton();
            this.wednesdayRadioButton = new System.Windows.Forms.RadioButton();
            this.tuesdayRadioButton = new System.Windows.Forms.RadioButton();
            this.mondayRadioButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addLessonButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.profTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadFilesButton
            // 
            this.loadFilesButton.Location = new System.Drawing.Point(40, 26);
            this.loadFilesButton.Name = "loadFilesButton";
            this.loadFilesButton.Size = new System.Drawing.Size(152, 23);
            this.loadFilesButton.TabIndex = 0;
            this.loadFilesButton.Text = "Load XML and XSD Files";
            this.loadFilesButton.UseVisualStyleBackColor = true;
            this.loadFilesButton.Click += new System.EventHandler(this.loadFilesButton_Click);
            // 
            // xmlLabel
            // 
            this.xmlLabel.AutoSize = true;
            this.xmlLabel.Location = new System.Drawing.Point(49, 272);
            this.xmlLabel.Name = "xmlLabel";
            this.xmlLabel.Size = new System.Drawing.Size(93, 13);
            this.xmlLabel.TabIndex = 1;
            this.xmlLabel.Text = "XML File Loaded: ";
            // 
            // xsdLabel
            // 
            this.xsdLabel.AutoSize = true;
            this.xsdLabel.Location = new System.Drawing.Point(49, 294);
            this.xsdLabel.Name = "xsdLabel";
            this.xsdLabel.Size = new System.Drawing.Size(93, 13);
            this.xsdLabel.TabIndex = 2;
            this.xsdLabel.Text = "XSD File Loaded: ";
            // 
            // validationButton
            // 
            this.validationButton.Location = new System.Drawing.Point(40, 56);
            this.validationButton.Name = "validationButton";
            this.validationButton.Size = new System.Drawing.Size(75, 23);
            this.validationButton.TabIndex = 3;
            this.validationButton.Text = "Validate";
            this.validationButton.UseVisualStyleBackColor = true;
            this.validationButton.Click += new System.EventHandler(this.validationButton_Click);
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.AllowUserToAddRows = false;
            this.resultsDataGridView.AllowUserToDeleteRows = false;
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Location = new System.Drawing.Point(223, 26);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.ReadOnly = true;
            this.resultsDataGridView.Size = new System.Drawing.Size(537, 234);
            this.resultsDataGridView.TabIndex = 4;
            // 
            // allDaysRadioButton
            // 
            this.allDaysRadioButton.AutoSize = true;
            this.allDaysRadioButton.Location = new System.Drawing.Point(3, 3);
            this.allDaysRadioButton.Name = "allDaysRadioButton";
            this.allDaysRadioButton.Size = new System.Drawing.Size(63, 17);
            this.allDaysRadioButton.TabIndex = 5;
            this.allDaysRadioButton.TabStop = true;
            this.allDaysRadioButton.Text = "All Days";
            this.allDaysRadioButton.UseVisualStyleBackColor = true;
            this.allDaysRadioButton.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.sundayRadioButton);
            this.panel1.Controls.Add(this.saturdayRadioButton);
            this.panel1.Controls.Add(this.fridayRadioButton);
            this.panel1.Controls.Add(this.thursdayRadioButton);
            this.panel1.Controls.Add(this.wednesdayRadioButton);
            this.panel1.Controls.Add(this.tuesdayRadioButton);
            this.panel1.Controls.Add(this.mondayRadioButton);
            this.panel1.Controls.Add(this.allDaysRadioButton);
            this.panel1.Location = new System.Drawing.Point(12, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 6;
            // 
            // sundayRadioButton
            // 
            this.sundayRadioButton.AutoSize = true;
            this.sundayRadioButton.Location = new System.Drawing.Point(94, 72);
            this.sundayRadioButton.Name = "sundayRadioButton";
            this.sundayRadioButton.Size = new System.Drawing.Size(61, 17);
            this.sundayRadioButton.TabIndex = 12;
            this.sundayRadioButton.TabStop = true;
            this.sundayRadioButton.Text = "Sunday";
            this.sundayRadioButton.UseVisualStyleBackColor = true;
            this.sundayRadioButton.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // saturdayRadioButton
            // 
            this.saturdayRadioButton.AutoSize = true;
            this.saturdayRadioButton.Location = new System.Drawing.Point(94, 49);
            this.saturdayRadioButton.Name = "saturdayRadioButton";
            this.saturdayRadioButton.Size = new System.Drawing.Size(67, 17);
            this.saturdayRadioButton.TabIndex = 11;
            this.saturdayRadioButton.TabStop = true;
            this.saturdayRadioButton.Text = "Saturday";
            this.saturdayRadioButton.UseVisualStyleBackColor = true;
            this.saturdayRadioButton.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // fridayRadioButton
            // 
            this.fridayRadioButton.AutoSize = true;
            this.fridayRadioButton.Location = new System.Drawing.Point(95, 26);
            this.fridayRadioButton.Name = "fridayRadioButton";
            this.fridayRadioButton.Size = new System.Drawing.Size(53, 17);
            this.fridayRadioButton.TabIndex = 10;
            this.fridayRadioButton.TabStop = true;
            this.fridayRadioButton.Text = "Friday";
            this.fridayRadioButton.UseVisualStyleBackColor = true;
            this.fridayRadioButton.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // thursdayRadioButton
            // 
            this.thursdayRadioButton.AutoSize = true;
            this.thursdayRadioButton.Location = new System.Drawing.Point(95, 3);
            this.thursdayRadioButton.Name = "thursdayRadioButton";
            this.thursdayRadioButton.Size = new System.Drawing.Size(69, 17);
            this.thursdayRadioButton.TabIndex = 9;
            this.thursdayRadioButton.TabStop = true;
            this.thursdayRadioButton.Text = "Thursday";
            this.thursdayRadioButton.UseVisualStyleBackColor = true;
            this.thursdayRadioButton.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // wednesdayRadioButton
            // 
            this.wednesdayRadioButton.AutoSize = true;
            this.wednesdayRadioButton.Location = new System.Drawing.Point(3, 72);
            this.wednesdayRadioButton.Name = "wednesdayRadioButton";
            this.wednesdayRadioButton.Size = new System.Drawing.Size(82, 17);
            this.wednesdayRadioButton.TabIndex = 8;
            this.wednesdayRadioButton.TabStop = true;
            this.wednesdayRadioButton.Text = "Wednesday";
            this.wednesdayRadioButton.UseVisualStyleBackColor = true;
            this.wednesdayRadioButton.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // tuesdayRadioButton
            // 
            this.tuesdayRadioButton.AutoSize = true;
            this.tuesdayRadioButton.Location = new System.Drawing.Point(3, 49);
            this.tuesdayRadioButton.Name = "tuesdayRadioButton";
            this.tuesdayRadioButton.Size = new System.Drawing.Size(66, 17);
            this.tuesdayRadioButton.TabIndex = 7;
            this.tuesdayRadioButton.TabStop = true;
            this.tuesdayRadioButton.Text = "Tuesday";
            this.tuesdayRadioButton.UseVisualStyleBackColor = true;
            this.tuesdayRadioButton.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // mondayRadioButton
            // 
            this.mondayRadioButton.AutoSize = true;
            this.mondayRadioButton.Location = new System.Drawing.Point(3, 26);
            this.mondayRadioButton.Name = "mondayRadioButton";
            this.mondayRadioButton.Size = new System.Drawing.Size(63, 17);
            this.mondayRadioButton.TabIndex = 6;
            this.mondayRadioButton.TabStop = true;
            this.mondayRadioButton.Text = "Monday";
            this.mondayRadioButton.UseVisualStyleBackColor = true;
            this.mondayRadioButton.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dayTextBox);
            this.panel2.Controls.Add(this.profTextBox);
            this.panel2.Controls.Add(this.titleTextBox);
            this.panel2.Controls.Add(this.addLessonButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(223, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 100);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Professor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Day:";
            // 
            // addLessonButton
            // 
            this.addLessonButton.Location = new System.Drawing.Point(334, 33);
            this.addLessonButton.Name = "addLessonButton";
            this.addLessonButton.Size = new System.Drawing.Size(102, 23);
            this.addLessonButton.TabIndex = 3;
            this.addLessonButton.Text = "Add new Lesson";
            this.addLessonButton.UseVisualStyleBackColor = true;
            this.addLessonButton.Click += new System.EventHandler(this.addLessonButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(94, 12);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 4;
            // 
            // profTextBox
            // 
            this.profTextBox.Location = new System.Drawing.Point(94, 37);
            this.profTextBox.Name = "profTextBox";
            this.profTextBox.Size = new System.Drawing.Size(100, 20);
            this.profTextBox.TabIndex = 5;
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(94, 64);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(100, 20);
            this.dayTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resultsDataGridView);
            this.Controls.Add(this.validationButton);
            this.Controls.Add(this.xsdLabel);
            this.Controls.Add(this.xmlLabel);
            this.Controls.Add(this.loadFilesButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadFilesButton;
        private System.Windows.Forms.Label xmlLabel;
        private System.Windows.Forms.Label xsdLabel;
        private System.Windows.Forms.Button validationButton;
        private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.RadioButton allDaysRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton sundayRadioButton;
        private System.Windows.Forms.RadioButton saturdayRadioButton;
        private System.Windows.Forms.RadioButton fridayRadioButton;
        private System.Windows.Forms.RadioButton thursdayRadioButton;
        private System.Windows.Forms.RadioButton wednesdayRadioButton;
        private System.Windows.Forms.RadioButton tuesdayRadioButton;
        private System.Windows.Forms.RadioButton mondayRadioButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addLessonButton;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox profTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
    }
}

