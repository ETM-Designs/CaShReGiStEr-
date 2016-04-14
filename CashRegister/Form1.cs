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
using System.Collections;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        AutoCompleteComboBox cb = null;//the is the var for the combobox auto complete
        private FileStream raFile = null;//this is the data from the other promt
        private String lpath = "list.txt";//userlist
        ArrayList data = null;//holds the data
        ArrayList list = null;//holds the active list
        ArrayList ids = null;//holds the list of ids for the combo box
        private int index = -1;//index of the click info
   

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                raFile = new FileStream("Inventory.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                readFile();//reads in the rafile into data
               
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error Creating Stream");
            }
            //if there is a userlist file to remove it and start fresh
            if (File.Exists(lpath))
            {   
                if ((MessageBox.Show("Would you like to delete User list?", "Confirm Record Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)) ==
                (System.Windows.Forms.DialogResult.Yes))
                {
                    File.Delete(lpath);//delete file
                    StreamWriter sw = new StreamWriter(lpath, true);//recreate the file
                    sw.Close();//close the writer
                }
            }


            //for the combobox
             cb = new AutoCompleteComboBox();
            foreach (string id in ids)
            {
                cb.Items.Add(id);
            }
            cb.LimitToList = true;
            cb.NotInList += new CancelEventHandler(combobox_NotInList);
            //seting user edit permissions 
            lblID.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            lblName.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            lblPrice.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            lblID.KeyPress += lblID_KeyPress;
            lblName.KeyPress += lblName_KeyPress;
            lblPrice.KeyPress += lblPrice_KeyPress; 
        }

        private void combobox_NotInList(object sender, CancelEventArgs e)
        {
            MessageBox.Show("You entered a value that was not consistent with the list provided. Please try again.");
            e.Cancel = true;
        }

        private void updateList()
        {
            listBox1.Items.Clear();//clear the listbox
            foreach(string record in list)//loop around the list 
            {
                listBox1.Items.Add(record);//add them to the box
            }
        }
        private void readList()
        {
            StreamReader sr = new StreamReader(lpath);//start the reader on the listpage
            string record = sr.ReadLine();//read a line
            while (record != null)//if not pass
            {
                listBox1.Items.Add(record);//add the record to the list
                list.Add(record);//add the record to the list
                record = sr.ReadLine();//read next line
            }
            sr.Close();//close the line
        }
        private void readFile()
        {   
            //starting the array list
            list = new ArrayList();
            data = new ArrayList();
            ids = new ArrayList();
            //start the reader
            //read in the data to the listview file
            ItemRecordRA ra = new ItemRecordRA();
            try
            {
                raFile.Seek(0, SeekOrigin.Begin);
                for (int i = 0; i < 100; i++)
                {
                    ra.read(raFile);//read the data in from the file
                    if (ra.Id > 0)
                    {
                        data.Add(ra.Id + "," + ra.Desc + "," + ra.Price.ToString("c"));//add the data to the array
                        ids.Add(ra.Id);//add the ids to the array for combo box
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

      
        void lblPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        void lblName_KeyPress(object sender, KeyPressEventArgs e)
        {
           // char c = e.KeyChar;
        }

        void lblID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmdInsert_Click(object sender, EventArgs e)
        { 
            //this loops around the array list to out put the data
            foreach(string info in data)
            {
                char[] delims = { ',' };//set the delim
                string[] tokens = info.Split(delims);//not split the info from the data .txt
                string id = tokens[0];//get the id and set it to id
                if (id.Equals(lblID.Text))//if the id = the lblid then add the data to the list
                {
                    list.Add(info);//add the item to the list 
                    updateList();//update the listbox
                }
            }
        }

        private bool dataCheck()
        {
            //this is just a basic checker if the txt files are getting checked
            //just checks for Nulls before commiting then to the file
            if (lblID.Equals(null)||
                lblName.Equals(null)||
                lblPrice.Equals(null)||
                lblID.Equals("")||
                lblName.Equals("")||
                lblPrice.Equals(""))
            {
                return false;
            }
            return true;
        }

        private void clearText()
        {
            lblID.Text = "";
            lblName.Text = "";
            lblPrice.Text = "";
        }

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBox1.SelectedIndex;//gets the select index
            if (index > -1)
            {   
                string record = listBox1.Items[index].ToString();//put the record in record
                char[] delims = { ',' };
                string[] tokens = record.Split(delims);//splits it 
                //fills the form boxs
                lblID.Text = tokens[0];
                lblName.Text = tokens[1];
                lblPrice.Text = tokens[2];
                cmdAdd.Enabled = false;
                cmdDelete.Enabled = true;
            }
        }
        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Record Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                //delete the item on the listbox
                list.RemoveAt(index-1);
                updateList();

            }
            cmdAdd.Enabled = true;
            cmdDelete.Enabled = false;
        }
        private void cmdSave_Click(object sender, EventArgs e)
        {
            //this will be used for the user to save there list to a text file for it to be printed
            //delete file
            File.Delete(lpath);
            StreamWriter sw = new StreamWriter(lpath, true);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sw.WriteLine(listBox1.Items[i].ToString());//write data
            }
            sw.Close();//close writer
        }
        //this opens up the data editer to change the data values
        private void Itemlist_Click(object sender, EventArgs e)
        {
            raFile.Close();//close the file or else you will die

            ListEditor form2 = new ListEditor();
            form2.ShowDialog(this);
            //add this to your exit button System.Environment.Exit(1);
        }

        //done
        private void cmd1_Click(object sender, EventArgs e)
        {
            if (lblID.Text.Length < 10)
            {
                lblID.Text = lblID.Text + "1";
            }
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            if (lblID.Text.Length < 10)
            {
                lblID.Text = lblID.Text + "2";
            }
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            if (lblID.Text.Length < 10)
            {
                lblID.Text = lblID.Text + "3";
            }
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            if (lblID.Text.Length < 10)
            {
                lblID.Text = lblID.Text + "4";
            }
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            if (lblID.Text.Length < 10)
            {
                lblID.Text = lblID.Text + "5";
            }
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            if (lblID.Text.Length < 10)
            {
                lblID.Text = lblID.Text + "6";
            }
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            if (lblID.Text.Length < 10)
            {
                lblID.Text = lblID.Text + "7";
            }
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            if (lblID.Text.Length < 10)
            {
                lblID.Text = lblID.Text + "8";
            }
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            if (lblID.Text.Length < 10)
            {
                lblID.Text = lblID.Text + "9";
            }
        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            if (lblID.Text.Length < 10)
            {
                lblID.Text = lblID.Text + "0";
            }
        }


        public class AutoCompleteComboBox : System.Windows.Forms.ComboBox
        {
            public event System.ComponentModel.CancelEventHandler NotInList;

            private bool _limitToList = true;
            private bool _inEditMode = false;

            public AutoCompleteComboBox()
                : base()
            {
            }

            [Category("Behavior")]
            public bool LimitToList
            {
                get { return _limitToList; }
                set { _limitToList = value; }
            }

            protected virtual void
                OnNotInList(System.ComponentModel.CancelEventArgs e)
            {
                if (NotInList != null)
                {
                    NotInList(this, e);
                }
            }

            protected override void OnTextChanged(System.EventArgs e)
            {
                if (_inEditMode)
                {
                    string input = Text;
                    int index = FindString(input);

                    if (index >= 0)
                    {
                        _inEditMode = false;
                        SelectedIndex = index;
                        _inEditMode = true;
                        Select(input.Length, Text.Length);
                    }
                }

                base.OnTextChanged(e);
            }

            protected override void
                OnValidating(System.ComponentModel.CancelEventArgs e)
            {
                if (this.LimitToList)
                {
                    int pos = this.FindStringExact(this.Text);

                    if (pos == -1)
                    {
                        OnNotInList(e);
                    }
                    else
                    {
                        this.SelectedIndex = pos;
                    }
                }

                base.OnValidating(e);
            }

            protected override void
                OnKeyDown(System.Windows.Forms.KeyEventArgs e)
            {
                _inEditMode =
                    (e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete);
                base.OnKeyDown(e);
            }
        }
    }
}
