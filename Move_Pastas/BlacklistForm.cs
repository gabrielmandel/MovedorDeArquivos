﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Move_Pastas
{
    public partial class frmFolderBlacklist : Form
    {
        public frmFolderBlacklist()
        {
            InitializeComponent();
            //read the file
            string arquivo = @"C:\Workspace\folderBlacklist.txt";
            if (File.Exists(arquivo))
            {
                StreamReader file = new StreamReader(arquivo);

                //set list view in details mode
                listFolderBlacklist.View = View.Details;

                //Set columns in listview
                listFolderBlacklist.Columns.Add("Pastas");

                string line = "";
                //read text file line by line.     
                while ((line = file.ReadLine()) != null)
                {
                    listFolderBlacklist.Items.Add(line);

                }
                file.Close();
            }
            else
            {
                MessageBox.Show("Não foi encontrado arquvios em:" + arquivo);
                Close();
            }
        }

        private void addFolderBlacklist_Click(object sender, EventArgs e)
        {
            string arquivo = @"C:\Workspace\folderBlacklist.txt";            

            StreamWriter writer = new StreamWriter(arquivo,true);

            string blacklistFolderItem = txtBlacklist.Text;
            listFolderBlacklist.Items.Add(blacklistFolderItem);
            
            writer.WriteLine(blacklistFolderItem);
            writer.Close();
        }
    }
}
