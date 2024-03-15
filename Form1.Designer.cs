namespace DemoDataBinding1
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
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            checkBoxCurs3 = new CheckBox();
            checkBoxCurs2 = new CheckBox();
            checkBoxCurs1 = new CheckBox();
            label1 = new Label();
            dateTimePickerData2 = new DateTimePicker();
            radioTarda = new RadioButton();
            radioMati = new RadioButton();
            labelError = new Label();
            buttonEsborrar = new Button();
            buttonAfegir = new Button();
            label8 = new Label();
            textBoxNom2 = new TextBox();
            grid = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxEmail2 = new TextBox();
            textBoxCognoms2 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(875, 574);
            tabControl1.TabIndex = 2;
            tabControl1.KeyDown += tabControl1_KeyDown;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(checkBoxCurs3);
            tabPage3.Controls.Add(checkBoxCurs2);
            tabPage3.Controls.Add(checkBoxCurs1);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(dateTimePickerData2);
            tabPage3.Controls.Add(radioTarda);
            tabPage3.Controls.Add(radioMati);
            tabPage3.Controls.Add(labelError);
            tabPage3.Controls.Add(buttonEsborrar);
            tabPage3.Controls.Add(buttonAfegir);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(textBoxNom2);
            tabPage3.Controls.Add(grid);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(textBoxEmail2);
            tabPage3.Controls.Add(textBoxCognoms2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(867, 541);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "grid";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBoxCurs3
            // 
            checkBoxCurs3.AutoSize = true;
            checkBoxCurs3.Location = new Point(358, 433);
            checkBoxCurs3.Name = "checkBoxCurs3";
            checkBoxCurs3.Size = new Size(84, 24);
            checkBoxCurs3.TabIndex = 27;
            checkBoxCurs3.Text = "Curset 3";
            checkBoxCurs3.UseVisualStyleBackColor = true;
            // 
            // checkBoxCurs2
            // 
            checkBoxCurs2.AutoSize = true;
            checkBoxCurs2.Location = new Point(358, 403);
            checkBoxCurs2.Name = "checkBoxCurs2";
            checkBoxCurs2.Size = new Size(84, 24);
            checkBoxCurs2.TabIndex = 26;
            checkBoxCurs2.Text = "Curset 2";
            checkBoxCurs2.UseVisualStyleBackColor = true;
            // 
            // checkBoxCurs1
            // 
            checkBoxCurs1.AutoSize = true;
            checkBoxCurs1.Location = new Point(358, 373);
            checkBoxCurs1.Name = "checkBoxCurs1";
            checkBoxCurs1.Size = new Size(84, 24);
            checkBoxCurs1.TabIndex = 25;
            checkBoxCurs1.Text = "Curset 1";
            checkBoxCurs1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 441);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 24;
            label1.Text = "Data Naixement";
            // 
            // dateTimePickerData2
            // 
            dateTimePickerData2.Location = new Point(18, 464);
            dateTimePickerData2.Name = "dateTimePickerData2";
            dateTimePickerData2.Size = new Size(272, 27);
            dateTimePickerData2.TabIndex = 23;
            // 
            // radioTarda
            // 
            radioTarda.AutoSize = true;
            radioTarda.Location = new Point(358, 312);
            radioTarda.Margin = new Padding(3, 4, 3, 4);
            radioTarda.Name = "radioTarda";
            radioTarda.Size = new Size(112, 24);
            radioTarda.TabIndex = 22;
            radioTarda.TabStop = true;
            radioTarda.Text = "Horari Tarda";
            radioTarda.UseVisualStyleBackColor = true;
            // 
            // radioMati
            // 
            radioMati.AutoSize = true;
            radioMati.Location = new Point(358, 278);
            radioMati.Margin = new Padding(3, 4, 3, 4);
            radioMati.Name = "radioMati";
            radioMati.Size = new Size(106, 24);
            radioMati.TabIndex = 21;
            radioMati.TabStop = true;
            radioMati.Text = "Horari Matí";
            radioMati.UseVisualStyleBackColor = true;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(621, 464);
            labelError.Name = "labelError";
            labelError.Size = new Size(190, 20);
            labelError.TabIndex = 20;
            labelError.Text = "Has de seleccionar una fila!";
            // 
            // buttonEsborrar
            // 
            buttonEsborrar.Location = new Point(655, 400);
            buttonEsborrar.Margin = new Padding(3, 4, 3, 4);
            buttonEsborrar.Name = "buttonEsborrar";
            buttonEsborrar.Size = new Size(126, 57);
            buttonEsborrar.TabIndex = 4;
            buttonEsborrar.Text = "ELIMINAR";
            buttonEsborrar.UseVisualStyleBackColor = true;
            buttonEsborrar.Click += buttonEsborrar_Click;
            // 
            // buttonAfegir
            // 
            buttonAfegir.Location = new Point(655, 278);
            buttonAfegir.Margin = new Padding(3, 4, 3, 4);
            buttonAfegir.Name = "buttonAfegir";
            buttonAfegir.Size = new Size(126, 61);
            buttonAfegir.TabIndex = 3;
            buttonAfegir.Text = "AFEGIR";
            buttonAfegir.UseVisualStyleBackColor = true;
            buttonAfegir.Click += buttonAfegir_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 17);
            label8.Name = "label8";
            label8.Size = new Size(122, 20);
            label8.TabIndex = 17;
            label8.Text = "Gestió d'alumnes";
            // 
            // textBoxNom2
            // 
            textBoxNom2.Location = new Point(19, 277);
            textBoxNom2.Margin = new Padding(3, 4, 3, 4);
            textBoxNom2.Name = "textBoxNom2";
            textBoxNom2.Size = new Size(181, 27);
            textBoxNom2.TabIndex = 0;
            // 
            // grid
            // 
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new Point(9, 41);
            grid.Margin = new Padding(3, 4, 3, 4);
            grid.Name = "grid";
            grid.RowHeadersWidth = 51;
            grid.RowTemplate.Height = 25;
            grid.Size = new Size(848, 200);
            grid.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 373);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 14;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 312);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 13;
            label6.Text = "Cognoms";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 251);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 12;
            label7.Text = "Nom";
            // 
            // textBoxEmail2
            // 
            textBoxEmail2.Location = new Point(18, 397);
            textBoxEmail2.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail2.Name = "textBoxEmail2";
            textBoxEmail2.Size = new Size(232, 27);
            textBoxEmail2.TabIndex = 2;
            // 
            // textBoxCognoms2
            // 
            textBoxCognoms2.Location = new Point(18, 336);
            textBoxCognoms2.Margin = new Padding(3, 4, 3, 4);
            textBoxCognoms2.Name = "textBoxCognoms2";
            textBoxCognoms2.Size = new Size(252, 27);
            textBoxCognoms2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 563);
            Controls.Add(tabControl1);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage3;
        private Label label8;
        private TextBox textBoxNom2;
        private DataGridView grid;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxEmail2;
        private TextBox textBoxCognoms2;
        private Button buttonEsborrar;
        private Button buttonAfegir;
        private Label labelError;
        private RadioButton radioTarda;
        private RadioButton radioMati;
        private Label label1;
        private DateTimePicker dateTimePickerData2;
        private CheckBox checkBoxCurs3;
        private CheckBox checkBoxCurs2;
        private CheckBox checkBoxCurs1;
    }
}