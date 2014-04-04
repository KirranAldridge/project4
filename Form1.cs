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

///Copyright 2014 Kirran Aldridge
///
///This file is part of AntiVirus.
///
///AntiVirus is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
///
///AntiVirus is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
///
namespace AntiVirus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //user clicks on scan button
        private void scan_Click(object sender, EventArgs e)
        {
            //open a folder browse dialog.
            folderBrowserDialog1.ShowDialog();
            bool virusFound = false;

            scan.Enabled = false;
            try
            {
                //read virus names from text file into an array
                string [] viruses = File.ReadLines(@"c:\antivirus\viruslist.txt").ToArray();

                List<string> vFound = new List<string>();

                VirusesFound.Text = "searching files...";
                //loop through the list of viruses and search the directories for the virus.
                foreach (var virus in viruses)
                {
                    //populate an array with all locations of the virus found
                    string[] virusItems = Directory.GetFiles(folderBrowserDialog1.SelectedPath, virus.ToString(), SearchOption.AllDirectories);
                    foreach (string item in virusItems)
                    {
                        VirusesFound.Text += item;
                        virusFound = true;
                    }
                }

                if  (!virusFound)
                {
                    VirusesFound.Text = "No viruses found";
                }
            }
            catch (UnauthorizedAccessException)
            {
            }
            catch (FileNotFoundException ex)
            {
                Message.Text = string.Format("Problem loading Viruslist.txt. Error: {0}", ex.Message);
            }
            finally 
            {
                scan.Enabled = true;
            }
        }
    }
}
