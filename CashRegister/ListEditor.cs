using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CashRegister
{
    public partial class ListEditor : Form
    {
        private FileStream raFile = null;
        private string origId = "";
        public ListEditor()
        {
            InitializeComponent();
        }

        void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c != 8)
            {
                if ((txtDesc.Text.Length>0) && (c<97||c>122 )){
                    e.Handled = true;
                }
                if ((txtDesc.Text.Length < 1) && (c < 65 || c > 90))
                {
                    e.Handled = true;
                }
            }
        }

        void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c != 8 && c != 46)
            {
                if (c < 48 || c > 57)
                {
                    e.Handled = true;
                }

            }  
        }

        void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c != 8)
            {
                if (c < 48 || c > 57)
                {
                    e.Handled = true;
                }
            }
        }


        private void cmdExit_Click(object sender, EventArgs e)
        {
            raFile.Close();
            this.Close();
        }

        private void cmdIns_Click(object sender, EventArgs e)
        {
            if (dataGood())
            {
                int id = Convert.ToInt32(txtID.Text);
                if (validID(id))
                {
                    string desc = txtDesc.Text;
                    double price = Convert.ToDouble(txtPrice.Text);
                    ItemRecordRA ra = new ItemRecordRA(id, desc, price);
                    try
                    {
                        raFile.Seek((id - 1) * 28, SeekOrigin.Begin);
                        ra.write(raFile);
                        readFile();
                        clearText();
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
            }
        }

        private void cmdUp_Click(object sender, EventArgs e)
        {
            if (dataGood())
            {
                int id = Convert.ToInt32(txtID.Text);
                string desc = txtDesc.Text;
                string sPrice = txtPrice.Text;
                if (sPrice[0] == '$')
                {
                    sPrice = sPrice.Remove(0, 1);
                }
                double price = Convert.ToDouble(sPrice);
                ItemRecordRA ra = new ItemRecordRA(id, desc, price);
                try
                {
                    //Position file pointer
                    raFile.Seek((id - 1) * 28, SeekOrigin.Begin);
                    ra.write(raFile);
                    ra = new ItemRecordRA();
                    raFile.Seek((Convert.ToInt32(origId) - 1) * 28, SeekOrigin.Begin);
                    ra.write(raFile);
                    readFile();
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Error Updating");
                }
                setControlState("i");
                clearText();
            }
        }

        private void cmdDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                //Delete Record
                int id = Convert.ToInt32(txtID.Text);
                ItemRecordRA ra = new ItemRecordRA();
                try
                {
                    raFile.Seek((id - 1) * 28, SeekOrigin.Begin);
                    ra.write(raFile);
                    readFile();
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Error Deleting");
                }
            }
            setControlState("i");
            clearText();
        }

        private void ListEditor_Load(object sender, EventArgs e)
        {
            try
            {
                raFile = new FileStream("Inventory.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                if (raFile.Length != 2800)
                {
                    initializeFile();
                }
                readFile();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error Creating Stream");
            }
            txtID.KeyPress +=txtID_KeyPress;
            txtDesc.KeyPress +=txtDesc_KeyPress;
            txtPrice.KeyPress+=txtPrice_KeyPress;
            txtID.ContextMenuStrip = new ContextMenuStrip();
            txtDesc.ContextMenuStrip = new ContextMenuStrip();
            txtPrice.ContextMenuStrip = new ContextMenuStrip();
        }

        private bool validID(int id)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int len = listBox1.Items[i].ToString().IndexOf(',');
                string sId = listBox1.Items[i].ToString().Substring(0, len);
                if (id == Convert.ToInt32(sId))
                {
                    MessageBox.Show("This account number already exists enter a new Account number", "Existing #", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Focus();
                    return false;
                }
            }

            return true;
        }

        private void clearText()
        {
            txtID.Text = "";
            txtDesc.Text = "";
            txtPrice.Text = "";
        }

        private void initializeFile()
        {
            MessageBox.Show("initializeFile() Called", "Initialized");
            ItemRecordRA ra = new ItemRecordRA();
            try
            {
                //Position pointer
                raFile.Seek(0, SeekOrigin.Begin);
                for (int i = 0; i < 100; i++)
                {
                    ra.write(raFile);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "An Error has Occured");
            }
        }

        private void setControlState(string state)
        {
            if (state.Equals("i"))
            {
                txtID.Enabled = true;
                txtDesc.Enabled = true;
                txtPrice.Enabled = true;
                cmdIns.Enabled = true;
                cmdDel.Enabled = false;
                cmdUp.Enabled = false;
            }
            else if (state.Equals("u/d"))
            {
                txtID.Enabled = true;
                txtDesc.Enabled = true;
                txtPrice.Enabled = true;
                cmdIns.Enabled = false;
                cmdDel.Enabled = true;
                cmdUp.Enabled = true;
            }
        }

        private void readFile()
        {
            listBox1.Items.Clear();
            ItemRecordRA ra = new ItemRecordRA();
            try
            {
                raFile.Seek(0, SeekOrigin.Begin);
                for (int i = 0; i < 100; i++)
                {
                    ra.read(raFile);
                    if (ra.Id > 0)
                    {
                        listBox1.Items.Add(ra.Id + "," + ra.Desc + "," + ra.Price.ToString("c"));

                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                string record = listBox1.Items[listBox1.SelectedIndex].ToString();
                string[] tokens = record.Split(new char[] { ',' });
                txtID.Text = tokens[0];
                txtDesc.Text = tokens[1];
                txtPrice.Text = tokens[2];
                setControlState("u/d");
                origId = txtID.Text;
            }
        }

        private bool dataGood()
        {
            if (txtID.Text.Length < 1 || txtDesc.Text.Length < 1 || txtPrice.Text.Length < 1)
            {
                MessageBox.Show("No fields may be empty!", "Empty Field Not Allowed");
                return false;
            }
            return true;
        }
    }
}
