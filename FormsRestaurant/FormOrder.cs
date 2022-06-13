using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Model;

namespace restaurantInterf
{
    /// <summary>
    /// Descrie funcționalitațile interfeței de gestionare a unei comenzi pe masa curentă
    /// </summary>
    public partial class FormOrder : Form
    {
        /// <summary>
        /// Controllerul care face legătura utilizatorului cu modelul
        /// </summary>
        private UserController _userController;

        /// <summary>
        /// Numărul mesei peste care s-a afișat formularul
        /// </summary>
        private int _numarMasa;

        /// <summary>
        /// Formularul cu mese
        /// </summary>
        private DashboardTables _tables;

        /// <summary>
        /// Datele comenzii corespunzatoare mesei curente
        /// </summary>
        private Comanda _comanda;

        /// <summary>
        /// Constructorul clasei
        /// </summary>
        public FormOrder()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inițializarea interfeței,a numarului mesei, a controllerului utilizator si al formularului cu mese
        /// </summary>
        /// <param name="numarMasa">Numarul mesei curente</param>
        /// <param name="userController">Controllerul utilizatorului curent</param>
        /// <param name="tables">Formularul cu mesele din restaurant</param>
        public FormOrder(int numarMasa, UserController userController, DashboardTables tables)
        {
            InitializeComponent();

            _userController = userController;
            _tables = tables;

            _numarMasa = numarMasa;
            Comanda c = _userController.GetComanda(_numarMasa);
            
            dataGridViewProduse.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            textBoxOrderOperator.Text = _userController.GetUsername();

            // daca există deja o comandă, preia datele din aceasta și le incarcă în dataGridViewProduse 
            if (c != null)
            {
                double total = 0;
                foreach (string numeProdus in c.DetaliiComanda.Keys)
                {
                    string[] row = new string[4];
                    row[0] = numeProdus;

                    Produs p = _userController.GetProdus(numeProdus);
                    row[1] = p.PretProdus.ToString();
                    row[2] = c.DetaliiComanda[numeProdus].ToString();
                    row[3] = (p.PretProdus * c.DetaliiComanda[numeProdus]).ToString();
                    total += p.PretProdus * c.DetaliiComanda[numeProdus];
                    dataGridViewProduse.Rows.Add(row);
                }

                textBoxOrderNumber.Text = c.NumarComanda.ToString();
                _comanda = c;
                textBoxOrderTable.Text = c.NumarMasa.ToString();
                labelTotal.Text = total.ToString();
            }
            else
            {
                // dacă nu există o comanda asociată mesei, o creează
                Comanda newCommand = new Comanda(_userController.getMaxNumberOfComanda() + 1, DateTime.Now, _userController.GetOspatar(_userController.GetUsername()).NumarOspatar, _numarMasa, new Dictionary<string, int>());
                
                if (_userController.AddComanda(newCommand))
                {
                    textBoxOrderOperator.Text = _userController.GetUsername();
                    textBoxOrderNumber.Text = newCommand.NumarComanda.ToString();
                    textBoxOrderTable.Text = newCommand.NumarMasa.ToString();
                    _comanda = newCommand;
                }      
            }

        }

        /// <summary>
        /// Actualizează datele afișate pe interfață
        /// </summary>
        public void RefreshControl()
        {
            Comanda c = _userController.GetComanda(_numarMasa);
            

            textBoxOrderOperator.Text = _userController.GetUsername();
            // daca există deja o comandă, preia datele din aceasta și le incarcă în dataGridViewProduse 
            if (c != null)
            {
                double total = 0;
                dataGridViewProduse.Rows.Clear();
                foreach (string numeProdus in c.DetaliiComanda.Keys)
                {
                    string[] row = new string[4];
                    row[0] = numeProdus;

                    Produs p = _userController.GetProdus(numeProdus);
                    row[1] = p.PretProdus.ToString();
                    row[2] = c.DetaliiComanda[numeProdus].ToString();
                    total += p.PretProdus * c.DetaliiComanda[numeProdus];
                    row[3] = (p.PretProdus * c.DetaliiComanda[numeProdus]).ToString();
                    dataGridViewProduse.Rows.Add(row);
                }

                textBoxOrderNumber.Text = c.NumarComanda.ToString();
                textBoxOrderTable.Text = c.NumarMasa.ToString();
                labelTotal.Text = total.ToString();
            }
            else
            {
                // dacă nu există o comanda asociată mesei, o creează

                Comanda newCommand = new Comanda(_userController.getMaxNumberOfComanda() + 1, DateTime.Now, _userController.GetOspatar(_userController.GetUsername()).NumarOspatar, _numarMasa, new Dictionary<string, int>());
                
                if (_userController.AddComanda(newCommand))
                {
                    textBoxOrderOperator.Text = _userController.GetUsername();
                    textBoxOrderNumber.Text = newCommand.NumarComanda.ToString();
                    textBoxOrderTable.Text = newCommand.NumarMasa.ToString();
                }
            }
        }

        /// <summary>
        /// La apăsarea butonului 'X' execută ieșirea din aplicație
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExitOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// La apăsarea butonului Add, afișează o fereastră nouă pentru adăugarea produsului
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddOrderItem_Click(object sender, EventArgs e)
        {
            FormAddItem aif = new FormAddItem(_userController,_comanda,this);
            aif.Show();
        }

        /// <summary>
        /// La apăsarea butonului Aplica, se salvează comanda in baza de date iar masa este marcată drept ocupată
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonApplyOrder_Click(object sender, EventArgs e)
        {
            // se salveaza datele in model
            List<Masa> mese = _userController.GetMese();
            foreach(Masa m in mese)
            {
                if(m.NumarMasa == _numarMasa)
                {
                    // se marcheaza masa ocupata daca nu este deja
                    if (m.StatusMasa == StatusEnum.Liber)
                    {
                        _userController.UpdateMasa(new Masa(m.NumarMasa, m.NumarLocuri, StatusEnum.Ocupat));
                        _tables.RefreshControl();

                        MessageBox.Show("Comanda ințializată cu succes!");
                        this.Close();
                    }
                }
            }
        }

        /// <summary>
        /// La apăsarea butonului Sterge, se execută șstergerea din model și de pe interfață a produsului selectat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteOrderItem_Click(object sender, EventArgs e)
        {
            if(dataGridViewProduse.SelectedRows.Count < 1)
            {
                MessageBox.Show("Nu ați selectat niciun rând de șters.");

            }
            else
            {
                Dictionary<string, int> detaliiComanda = new Dictionary<string, int>();
                detaliiComanda[dataGridViewProduse.SelectedCells[0].Value.ToString()] = Convert.ToInt32(dataGridViewProduse.SelectedCells[2].Value);

                Comanda newComanda = new Comanda(_comanda.NumarComanda, _comanda.DataComenzii, _comanda.NumarComanda, _comanda.NumarMasa, detaliiComanda);
                if(_userController.RemoveFromComanda(newComanda))
                {
                    MessageBox.Show("Ați sters înregistrarea cu succes!");
                    RefreshControl();
                }
            }
        }

        /// <summary>
        /// La apăsarea butonului Anuleaza Comanda se sterge comanda din model si de pe interfata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelOrder_Click(object sender, EventArgs e)
        {
            if(_userController.RemoveComanda(_comanda.NumarComanda))
            {
                MessageBox.Show("Ati sters comanda cu succes");
                List<Masa> mese = _userController.GetMese();
                int _numarLocuri = 0;

                foreach(Masa m in mese)
                {
                    if(m.NumarMasa == _numarMasa)
                    {
                        _numarLocuri = m.NumarLocuri;
                        break;
                    }
                }
                

                Masa masa = new Masa(_numarMasa, _numarLocuri, StatusEnum.Liber);
                _userController.UpdateMasa(masa);
                _tables.RefreshControl();
                this.Close();
            }
            else
            {
                MessageBox.Show("A avut loc o eroare la stergerea comenzii");
            }
        }

        /// <summary>
        /// La apasarea butonului Nota de plata, se executa printarea notei de plata in format PDF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPrintOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduse.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Bon_comanda.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Eroare la scriere fișier pe disc!" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            // formatarea datelor de pe bonul de comanda ce urmează a fi afișat

                            PdfPTable pdfTable = new PdfPTable(dataGridViewProduse.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                            
                            
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                            Paragraph para = new Paragraph();
                            para.Add("*********************************************************************************************************************");

                            Chunk chunk = new Chunk("Bon de Comanda", FontFactory.GetFont("dax-black"));
                            chunk.SetUnderline(0.5f, -1.5f);

                            Paragraph para1 = new Paragraph();
                            para1.Add(chunk);
                            para1.Alignment = Element.ALIGN_CENTER;
                            para1.SpacingAfter = 20;

                            Paragraph para2 = new Paragraph();
                            Paragraph para3 = new Paragraph(); 
                            para2.Add("Ospatar: " + textBoxOrderOperator.Text);
                            para2.SpacingAfter = 20;
                            para3.Add("Masa:" + _numarMasa);
                            para3.SpacingAfter = 20;

                            Paragraph para4 = new Paragraph();
                            para4.Add("Comanda: " + _comanda.NumarComanda);
                            para4.SpacingAfter = 20;

                            Paragraph para5 = new Paragraph();
                            para5.Add("Data comenzii: " + _comanda.DataComenzii);
                            para5.SpacingAfter = 20;
                            

                            Paragraph para6 = new Paragraph();
                            para6.Add("TOTAL DE PLATA: " +labelTotal.Text+"  LEI");
                            para6.SpacingAfter = 20;
                            para6.SpacingBefore = 20;
                            para6.Alignment = Element.ALIGN_RIGHT;

                            Paragraph para7 = new Paragraph();
                            para7.Add("*********************************************************************************************************************");
                            para7.SpacingBefore = 40;

                            // formatarea tabelului ce urmează a fi printat
                            foreach (DataGridViewColumn column in dataGridViewProduse.Columns)
                            {
                                
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                pdfTable.AddCell(cell);
                                
                                
                            }

                            foreach (DataGridViewRow row in dataGridViewProduse.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                    
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();

                                pdfDoc.Add(para);
                                pdfDoc.Add(para1);
                                pdfDoc.Add(para2);
                                pdfDoc.Add(para3);
                                pdfDoc.Add(para4);
                                pdfDoc.Add(para5);
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Add(para6);
                                pdfDoc.Add(para7);

                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Printare BON COMANDA cu succes!", "Info");

                            // ștergerea comenzii dupa printarea bonului
                            if (_userController.RemoveComanda(_comanda.NumarComanda))
                            {
                                List<Masa> mese = _userController.GetMese();
                                int _numarLocuri = 0;

                                foreach (Masa m in mese)
                                {
                                    if (m.NumarMasa == _numarMasa)
                                    {
                                        _numarLocuri = m.NumarLocuri;
                                        break;
                                    }
                                }


                                Masa masa = new Masa(_numarMasa, _numarLocuri, StatusEnum.Liber);
                                _userController.UpdateMasa(masa);
                                _tables.RefreshControl();
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Eroare :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nici o inregistrare!", "Info");
            }
        }

        
    }

}
    

