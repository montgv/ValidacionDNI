using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;


namespace FormClientes
{
    public partial class Form1 : Form
    {
        private int indice;
        public Form1()
        {
            InitializeComponent();
            indice = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void TCClientes_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (TCClientes.Controls[0] == TCClientes.SelectedTab)
                MessageBox.Show("Pasa");

            //your specific tabname 
            //this.TCClientes.SelectedTab.Name = "Personal";
            //this.TCClientes.SelectedTab(1);
            //Me.TClientes.TabPages(Me.TClientes.SelectedIndex).Text
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;


            //datagridview2 agregar boton en la misma fila
            DataGridViewButtonColumn buttonCol = new DataGridViewButtonColumn();
            buttonCol.Name = "btnNotes";
            buttonCol.HeaderText = "Mas información.";
            buttonCol.Text = "Pulsa...";
            buttonCol.Width = 80;
            buttonCol.UseColumnTextForButtonValue = true;
            //buttonCol.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridView2.Columns.Add(buttonCol);


            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //btn.HeaderText = "Haga clic...";
            //btn.Text = "a";
            //btn.Name = "btn";
            //btn.UseColumnTextForButtonValue = true;
            //this.dataGridView2.Columns.Add(btn);


            //trackbar
            trackBar1.Value = int.Parse(label26.Text);


            //contador listbox
            this.Tcontadorlistbox1.Text = this.listBox1.Items.Count.ToString();
            this.TContadorlistbox2.Text = this.listBox2.Items.Count.ToString();


            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void opcion1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void opcion1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opcion1");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nummax.Maximum = 100000;
            nummax.Minimum = 100;
            int max = Convert.ToInt32(nummax.Value);
            progressBar1.Maximum = max;
            progressBar1.Minimum = 0;
            progressBar1.PerformStep();
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            decimal porcentaje;

            porcentaje = (progressBar1.Value / nummax.Value) * 100;
            label1.Text = porcentaje.ToString() + "%";
        }

        private void btnr_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            label1.Text = "";
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

        }



        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTValidar_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(this.MTBemail.Text.Trim());
            if (!isValid)
            {
                MessageBox.Show("Email no válido.");
            } else
                MessageBox.Show("Email valido.");
        }

        private void TBNombre_Validating(object sender, CancelEventArgs e)
        {
            if (this.TBNombre.Text.Length == 0)
                errorProvider1.SetError(this.TBNombre, "Debe tener un valor");
            else
                errorProvider1.SetError(this.TBNombre, "");
        }

        private void TBApellido1_Validating(object sender, CancelEventArgs e)
        {
            if (this.TBApellido1.Text.Length == 0)
                errorProvider1.SetError(this.TBApellido1, "Debe tener un valor");
            else
                errorProvider1.SetError(this.TBApellido1, "");
        }

        private void TBApellido2_Validating(object sender, CancelEventArgs e)
        {
            if (this.TBApellido2.Text.Length == 0)
                errorProvider1.SetError(this.TBApellido2, "Debe tener un valor");
            else
                errorProvider1.SetError(this.TBApellido2, "");
        }

        private void TBSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBSaldo_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider2.Clear();
            try
            {
                int i = Convert.ToInt32(this.TBSaldo.Text);
            }
            catch
            {
                this.errorProvider2.Clear();
                this.errorProvider2.SetError(this.TBSaldo, " Ingrese Saldo numérico");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label26.Text = trackBar1.Value.ToString();
        }

        private void opción1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.PBEstado.Value = 2;
        }

        private void BTEnviar_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            mmsg.To.Add(this.TPara.Text);
            mmsg.Subject = this.TAsunto.Text;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            mmsg.Bcc.Add(this.TBcc.Text);

            mmsg.Body = this.TCuerpo.Text;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new System.Net.Mail.MailAddress("ecano@iesoretania.es");


            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();


            cliente.Credentials = new System.Net.NetworkCredential("ecano@iesoretania.es", "contraseña");

            cliente.Port = 587;
            cliente.EnableSsl = true;

            cliente.Host = "smtp.gmail.com";

            try
            {
                cliente.Send(mmsg);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en el envio");
            }
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void actualizar()
        {
            this.TContadorlistbox2.Text = this.listBox1.Items.Count.ToString();
            this.Tcontadorlistbox1.Text = this.listBox2.Items.Count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            MoveSelectedItems(this.listBox2, this.listBox1);
            actualizar_contador_listbox();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(this.listBox1, this.listBox2);
            actualizar_contador_listbox();
        }


        // Mover item de un listbox a otro
        private void MoveSelectedItems(ListBox lstFrom, ListBox lstTo)
        {
            while (lstFrom.SelectedItems.Count > 0)
            {
                string item = (string)lstFrom.SelectedItems[0];
                lstTo.Items.Add(item);
                lstFrom.Items.Remove(item);
            }
            SetButtonsEditable();
        }

        // Move all items from one ListBox to another.
        private void MoveAllItems(ListBox lstFrom, ListBox lstTo)
        {
            lstTo.Items.AddRange(lstFrom.Items);
            lstFrom.Items.Clear();
            SetButtonsEditable();
        }

        // Enable and disable buttons.MIRAR
        private void SetButtonsEditable()
        {
            //this.button3.Enabled = (this.listBox2.SelectedItems.Count > 0);
            //this.button4.Enabled = (this.listBox2.Items.Count > 0);
            //this.button5.Enabled = (this.listBox1.SelectedItems.Count > 0);
            //this.button6.Enabled = (this.listBox1.Items.Count > 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MoveAllItems(this.listBox1, this.listBox2);
            actualizar_contador_listbox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoveAllItems(this.listBox2, this.listBox1);
            actualizar_contador_listbox();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
            {
                if (this.checkedListBox1.GetItemChecked(i) == true)
                {

                    MessageBox.Show("Valores seleccinados " + this.checkedListBox1.Items[i].ToString());

                }

            }




        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Establecemos las propiedades del ListView
            this.listView1.View = View.Details;
            this.listView1.GridLines = true;
            this.listView1.FullRowSelect = true;

            //Añadimos las columnas al ListView
            this.listView1.Columns.Add("PDF", 500);
            this.listView1.Columns.Add("NIF", 70);
            this.listView1.Columns.Add("Importe", 70);

            //Añadimos los elementos (filas) al ListView
            string[] elementosFila = new string[3];
            ListViewItem elementoListView;

            //Añadimos una primera fila al ListView
            elementosFila[0] = "PDF 1";
            elementosFila[1] = "2222222V";
            elementosFila[2] = "2.254,00";
            elementoListView = new ListViewItem(elementosFila);
            listView1.Items.Add(elementoListView);

            //Añadimos una segunda fila al ListView
            elementosFila[0] = "PDF 2";
            elementosFila[1] = "3333333V";
            elementosFila[2] = "1.254,00";
            elementoListView = new ListViewItem(elementosFila);
            listView1.Items.Add(elementoListView);


        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog(); BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            //Aquí incluiremos los filtros que queramos.
            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Titulo del Dialogo";
            BuscarImagen.InitialDirectory = "C:\\"; BuscarImagen.FileName = this.textBox1.Text;
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                /// Si esto se cumple, capturamos la propiedad File Name y la guardamos en el control
                this.textBox12.Text = BuscarImagen.FileName; String Direccion = BuscarImagen.FileName; this.pictureBox2.ImageLocation = Direccion;
                //Pueden usar tambien esta forma para cargar la Imagen solo activenla y comenten la linea donde se cargaba anteriormente 
                //this.pictureBox1.ImageLocation = textBox1.Text;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox2.BackColor = colorDialog1.Color;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            indice++;

            if (indice > 3)
                indice = 0;
            this.EtiquetasImagenes.ImageIndex = indice;

            
            
            //this.imageList1.ImageSize = new Size(112, 112);
            //this.timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }

        private void listBox1_Validating(object sender, CancelEventArgs e)
        {
            //contador listbox
            this.Tcontadorlistbox1.Text = this.listBox1.Items.Count.ToString();
            this.TContadorlistbox2.Text = this.listBox2.Items.Count.ToString();
        }

        private void listBox2_Validating(object sender, CancelEventArgs e)
        {
            //contador listbox
            //this.Tcontadorlistbox1.Text = this.listBox1.Items.Count.ToString();
            //this.TContadorlistbox2.Text = this.listBox2.Items.Count.ToString();
        }

        private void listBox1_VisibleChanged(object sender, EventArgs e)
        {
            //contador listbox
            //this.Tcontadorlistbox1.Text = this.listBox1.Items.Count.ToString();
            //this.TContadorlistbox2.Text = this.listBox2.Items.Count.ToString();
        }
        private void actualizar_contador_listbox()
        {
            //contador listbox
            this.Tcontadorlistbox1.Text = this.listBox1.Items.Count.ToString();
            this.TContadorlistbox2.Text = this.listBox2.Items.Count.ToString();
        }

        private void btnCamptura_Click(object sender, EventArgs e)
        {
            this.txtFecha.Text = this.calendarioDate.Value.ToString();
            this.txtRango.Text = this.calendarioMonth.SelectionRange.ToString();
            this.txtInicio.Text = this.calendarioMonth.SelectionStart.Date.ToString();
            this.txtFin.Text = this.calendarioMonth.SelectionRange.End.ToString();


        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void label63_Click(object sender, EventArgs e)
        {

        }

    

           

        private void button13_Click_1(object sender, EventArgs e)
        {
            //lo puedo hacer de uno en un control o desactivando el contro Groupbox completo
            //this.groupBox1.Enabled = false;
            if (this.button13.Text == "Activar")
                {
                    foreach (Control c in this.groupBox1.Controls)
                    {
                        c.Enabled = true;
                        

                    }
                this.button13.Text = "Desactivar";
            }
                else
                {
                    foreach (Control c in this.groupBox1.Controls)
                    {
                        c.Enabled = false;
                    }
                    this.button13.Text = "Activar";
                    
                }
            }

        private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.IsBalloon = true;

            if (!e.IsValidInput)
            {
                toolTip1.ToolTipTitle = "DNI no válido";
                toolTip1.Show("El DNI no tiene el formato correcto, son 00000000L.", maskedTextBox1, 0, -20, 5000);
            } else
            {
                MaskedTextBox usuarioMask = (MaskedTextBox)e.ReturnValue;

                usuarioMask.TextMaskFormat;

                if
            }
        }
    }

}
