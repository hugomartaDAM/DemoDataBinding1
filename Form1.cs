namespace DemoDataBinding1
{
    public partial class Form1 : Form
    {
        //exemple3: afegir la propietat bs
        private BindingSource bs;
        public Form1()
        {
            InitializeComponent();

            // Datos del primer alumno
            Alumne alumne1 = new Alumne("Juan", "Martínez", "juan@example.com", new DateTime(2000, 5, 10), true, true, false, true);

            // Agregar los alumnos a la lista
            List<Alumne> alumnes = new List<Alumne>();
            alumnes.Add(alumne1);

            // BindingSource
            bs = new BindingSource();
            bs.DataSource = alumnes;

            // DataGridView
            grid.DataSource = bs;

            // Asignación de DataBindings
            textBoxNom2.DataBindings.Add("Text", bs, "Nom");
            textBoxCognoms2.DataBindings.Add("Text", bs, "Cognoms");
            textBoxEmail2.DataBindings.Add("Text", bs, "Email");
            dateTimePickerData2.DataBindings.Add("Text", bs, "Data_naixement");
            radioMati.DataBindings.Add("Checked", bs, "Horari_mati");
            radioTarda.DataBindings.Add("Checked", bs, "Horari_tarda");

            // Asignación de DataBindings para los cursos
            checkBoxCurs1.DataBindings.Add("Checked", bs, "Curset1");
            checkBoxCurs2.DataBindings.Add("Checked", bs, "Curset2");
            checkBoxCurs3.DataBindings.Add("Checked", bs, "Curset3");


            // Ocultar mensaje de error
            labelError.Visible = false;
        }

        //exemple 3
        //public BindingSource ComboBindingSource
        //{
        //    get { return bs; }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            //exemple 1
            
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            //crear llibre en blanc
            Alumne alumneNou = new Alumne();
            //afegir al bs
            bs.Add(alumneNou);
            //seleccionar el llibre nou al grid
            int rowIndex = bs.IndexOf(alumneNou);
            grid.CurrentCell = grid.Rows[rowIndex].Cells[1];
        }

        //exemple 3
        private void buttonEsborrar_Click(object sender, EventArgs e)
        {
            // Comprova si hi ha alguna fila seleccionada
            if (grid.SelectedRows.Count > 0)
            {
                // Obté la fila seleccionada
                DataGridViewRow selectedRow = grid.SelectedRows[0];

                // Pregunta si l'usuari està segur de voler esborrar la fila
                DialogResult result = MessageBox.Show("Estàs segur que vols esborrar aquesta fila?", "Confirma acció destructiva", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);

                // Si l'usuari està segur, esborra la fila
                if (result == DialogResult.Yes)
                {
                    grid.Rows.Remove(selectedRow);
                }
            }
            else
            {
                // Mostra el missatge d'error
                labelError.Visible = true;

                // Inicia el temporitzador per amagar el missatge
                var timer = new System.Windows.Forms.Timer();
                timer.Interval = 2500; // 2,5 segons
                timer.Tick += (s, ev) =>
                {
                    labelError.Visible = false;
                    timer.Stop();
                };
                timer.Start();
            }
        }


        //no utilitzat - cal que el control tingui el focus
        //i posar la propietat KeyPreview del From a true: this.KeyPreview = true;
        //private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    //gestionar combinació de tecles per Esborrar
        //    if (e.KeyCode == Keys.F8 && e.Modifiers == Keys.Control)
        //    {
        //        // cridar al mateix handler del botó d'esborrar
        //        buttonEsborrar_Click(sender, e);
        //    }
        //    //gestionar combinació de tecles per Afegir
        //    if (e.KeyCode == Keys.F5 && e.Modifiers == Keys.Control)
        //    {
        //        // simular click sobre botó Afegir
        //        buttonAfegir.PerformClick();
        //    }
        //}

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8 && e.Control)
            {
                //opció1: cridar al mateix event handler del buttonEsborrar
                buttonEsborrar_Click(sender, e);
                //marcar event com a gestionat
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F5 && e.Control)
            {
                //opció2: generar un event de click sobre el control
                buttonAfegir.PerformClick();
                //marcar event com a gestionat
                e.Handled = true;
            }
        }
    }
}