﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Robocopy_GUI
{
    public partial class frmRobocopy : Form
    {
        ProcessStartInfo pro;
        Process proStart;
        string sRoboCopyLocation = @"C:\Windows\System32\";
        string dLogArgument = "/log:";
        string dDestinationSave = " /XX ";
        string sourcePath = "";
        string TempString = "";
       // public delegate void AddItemDelegate(string item);
        public frmRobocopy()
        {
            InitializeComponent();
        }

        public void GetData(string Name)
        {
            TempString = Name;
        }

        private void frmRobocopy_Load(object sender, EventArgs e)
        {
             sourcePath = "/log:"+@""""+Application.StartupPath + @"\log2.log""";
             dLogArgument = sourcePath;
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
           lblSource.Text= GetFolderLocation();
        }
        public string GetFolderLocation(){
               if (fbdSource.ShowDialog() == DialogResult.OK)   
                {  
                    return fbdSource.SelectedPath;  
                }
            else {
               return "";
               }
        }

        private void btndestination_Click(object sender, EventArgs e)
        {
        lblDestination.Text= GetFolderLocation();
        }
        public void CreateCommand()
        {
            string dExtraArgument = "/MIR";
         
            if ((lblSource.Text.ToUpper().Trim()!= "SOURCE") && (lblSource.Text.Trim() != "") && Directory.Exists(lblSource.Text))
	            {
		        lblSource.Text=lblSource.Text.ToString().Replace("\\","//"); 

	            }else{
                 MessageBox.Show("Please select valid Source Folder");
                 return;

                }
             if ((lblDestination.Text.ToUpper().Trim()!= "DESTINATION") && (lblDestination.Text.Trim() != "") && Directory.Exists(lblDestination.Text))
	            {
                    lblDestination.Text = lblDestination.Text.ToString().Replace("\\", "//");
	            }else{
                 MessageBox.Show("Please select valid Destination Folder ");
                 return;
                }
             if (rbMIR.Checked==true)
             {
                 dExtraArgument = rbMIR.Tag.ToString();
             }else if(rbMov.Checked==true){
                 dExtraArgument = rbMov.Tag.ToString();
             }
             if (MessageBox.Show("Ready to Use the Command "+dExtraArgument +"??","",MessageBoxButtons.YesNo)==DialogResult.No)
             {
                  
                 return;
             }
             if (chkLog.CheckState==CheckState.Checked)
             {
                 dLogArgument = sourcePath;
             }
             else
             {
                 dLogArgument = "";
             }
             if (chkSaveDestination.CheckState==CheckState.Checked)
             {
                 dExtraArgument =dExtraArgument + " " + chkSaveDestination.Tag.ToString() + "";
             }
            // c 
            // k

             String dRoboFinal = " /K Robocopy.exe " + @"""" + @lblSource.Text.Trim() + @"//"" " + @"""" + @lblDestination.Text.Trim() + @"//""" + @" /V  /E /fft /R:1 /W:1 " + @dExtraArgument + " " + dLogArgument;
            // @"  /MIR";
            //Setting an instance of ProcessStartInfo class
            lblCommand.Text = dRoboFinal;
            // under System.Diagnostic Assembly Reference

             pro = new ProcessStartInfo();

            //Setting the FileName to be Started like in our

            //Project we are just going to start a CMD Window.

            pro.FileName = "cmd.exe";
            pro.WorkingDirectory = sRoboCopyLocation;
            pro.Arguments = dRoboFinal;
            pro.CreateNoWindow = false;
            pro.UseShellExecute = false;
            pro.WindowStyle = ProcessWindowStyle.Normal;
            pro.RedirectStandardInput = false;
            pro .RedirectStandardOutput = false;
            pro.RedirectStandardError = false;
            //Instead of using the above two line of codes, You

            // can just use the code below:

            // ProcessStartInfo pro = new ProcessStartInfo("cmd.exe");

            //Creating an Instance of the Process Class

            // which will help to execute our Process

             proStart = new Process();

            //Setting up the Process Name here which we are

            // going to start from ProcessStartInfo

            proStart.StartInfo = pro;
           // proStart.StartInfo.Arguments = dRoboFinal;

            //Calling the Start Method of Process class to

            // Invoke our Process viz 'cmd.exe'

            proStart.Start();
            //Wait for the process to be completed
            proStart.WaitForExit();
            //proStart.Close();
            //proStart.StartInfo.Arguments = dRoboFinal;
            //proStart.WaitForExit();
            //while (!proStart.HasExited)
            //{
            //    //update UI
            //    MessageBox.Show("Copy Complete");
            //}

        }
      /*  public void CreateXCopyCommand()
        {
            //XCOPY C:/SOURCE D:/DESTINATION /E /D /C /Y
            string dExtraArgument = " /E /D /C /Y ";

            if ((lblSource.Text.ToUpper().Trim() != "SOURCE") && (lblSource.Text.Trim() != "") && Directory.Exists(lblSource.Text))
            {
               // lblSource.Text = lblSource.Text.ToString().Replace("\\", "//");

            }
            else
            {
                MessageBox.Show("Please select valid Source Folder");
                return;

            }
            if ((lblDestination.Text.ToUpper().Trim() != "DESTINATION") && (lblDestination.Text.Trim() != "") && Directory.Exists(lblDestination.Text))
            {
              //  lblDestination.Text = lblDestination.Text.ToString().Replace("\\", "//");
            }
            else
            {
                MessageBox.Show("Please select valid Destination Folder ");
                return;
            }
            
            // c 
            // k

            String dRoboFinal = " /K xcopy.exe " + @"""" + @lblSource.Text.Trim()+ @""" "  + @"""" + @lblDestination.Text.Trim() + @""""  + @dExtraArgument ;
            // @"  /MIR";
            //Setting an instance of ProcessStartInfo class
            lblCommand.Text = dRoboFinal;
            // under System.Diagnostic Assembly Reference

            pro = new ProcessStartInfo();

            //Setting the FileName to be Started like in our

            //Project we are just going to start a CMD Window.

            pro.FileName = "cmd.exe";
            pro.WorkingDirectory = sRoboCopyLocation;
            pro.Arguments = dRoboFinal;
            pro.CreateNoWindow = false;
            pro.UseShellExecute = false;
            pro.WindowStyle = ProcessWindowStyle.Normal;
            pro.RedirectStandardInput = false;
            pro.RedirectStandardOutput = false;
            pro.RedirectStandardError = false;
            //Instead of using the above two line of codes, You

            // can just use the code below:

            // ProcessStartInfo pro = new ProcessStartInfo("cmd.exe");

            //Creating an Instance of the Process Class

            // which will help to execute our Process

            proStart = new Process();

            //Setting up the Process Name here which we are

            // going to start from ProcessStartInfo

            proStart.StartInfo = pro;
            // proStart.StartInfo.Arguments = dRoboFinal;

            //Calling the Start Method of Process class to

            // Invoke our Process viz 'cmd.exe'

            proStart.Start();
            //Wait for the process to be completed
            proStart.WaitForExit();
            //proStart.Close();
            //proStart.StartInfo.Arguments = dRoboFinal;
            //proStart.WaitForExit();
            //while (!proStart.HasExited)
            //{
            //    //update UI
            //    MessageBox.Show("Copy Complete");
            //}

        }
       * */
        private void btnCopy_Click(object sender, EventArgs e)
        {
            //if (rbStyleone.Checked==true)
            //{                CreateCommand();
            //}
            //else
            //{
            //    CreateXCopyCommand();
            //}
             
        }

        private void btnDeleteLocation_Click(object sender, EventArgs e)
        {
            lblDelete.Text = GetFolderLocation();
        }

        private void btnStartDelete_Click(object sender, EventArgs e)
        {
            DeleteCommand();
        }
        public void DeleteCommand()
        {


            if ((lblDelete.Text.ToUpper().Trim() != "DELETE") && (lblDelete.Text.Trim() != "") && Directory.Exists(lblDelete.Text))
            {
                lblDelete.Text = lblDelete.Text.ToString().Replace("\\", "//");

            }
            else
            {
                MessageBox.Show("Please select valid Delete Folder");
                return;

            }
            if ((lblemptyFolder.Text.ToUpper().Trim() != "EMPTY") && (lblemptyFolder.Text.Trim() != "") && Directory.Exists(lblemptyFolder.Text))
            {
                lblemptyFolder.Text = lblemptyFolder.Text.ToString().Replace("\\", "//");

            }
            else
            {
                MessageBox.Show("Please select valid Empty  Folder");
                return;

            }
           
            if (MessageBox.Show("Ready to Use the Command  Delete ??", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {

                return;
            }
            if (chkdeletelog.CheckState == CheckState.Checked)
            {
                dLogArgument = sourcePath;
            }
            else
            {
                dLogArgument = "";
            }
            // c 
            // k
          //  robocopy c:\emptyfolder "C:\delete\this folder\with a very long name" /purge

            String dRoboFinal = " /K Robocopy.exe " + @"""" + @lblemptyFolder.Text.Trim() + @"//"" " + @"""" + lblDelete.Text.Trim() + @"//""" + @" /PURGE /V " + " " + dLogArgument;
            // @"  /MIR";
            //Setting an instance of ProcessStartInfo class
            lblDeleteCommand.Text = dRoboFinal;
            // under System.Diagnostic Assembly Reference

            pro = new ProcessStartInfo();

            //Setting the FileName to be Started like in our

            //Project we are just going to start a CMD Window.

            pro.FileName = "cmd.exe";
            pro.WorkingDirectory = sRoboCopyLocation;
            pro.Arguments = dRoboFinal;
            pro.CreateNoWindow = false;
            pro.UseShellExecute = false;
            pro.WindowStyle = ProcessWindowStyle.Normal;
            pro.RedirectStandardInput = false;
            pro.RedirectStandardOutput = false;
            pro.RedirectStandardError = false;
            //Instead of using the above two line of codes, You

            // can just use the code below:

            // ProcessStartInfo pro = new ProcessStartInfo("cmd.exe");

            //Creating an Instance of the Process Class

            // which will help to execute our Process

            proStart = new Process();

            //Setting up the Process Name here which we are

            // going to start from ProcessStartInfo

            proStart.StartInfo = pro;
            // proStart.StartInfo.Arguments = dRoboFinal;

            //Calling the Start Method of Process class to

            // Invoke our Process viz 'cmd.exe'

            proStart.Start();
            //Wait for the process to be completed
            proStart.WaitForExit();
            //proStart.Close();
            //proStart.StartInfo.Arguments = dRoboFinal;
            //proStart.WaitForExit();
            //while (!proStart.HasExited)
            //{
            //    //update UI
            //    MessageBox.Show("Copy Complete");
            //}

        }

        private void btnEmptyLocation_Click(object sender, EventArgs e)
        {
            lblemptyFolder.Text = GetFolderLocation();
        }

        private void rbCopy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCopy.Checked==true)
            {
                ScCopyDelete.Panel2Collapsed = true;
            }

        }

        private void rbDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDelete.Checked == true)
            {
                ScCopyDelete.Panel1Collapsed = true;
            }
        }
        private void AddItemCallbackFn(string item)
        {

            TempString=item;

        }

        private void btnSourceUrl_Click(object sender, EventArgs e)
        {
            frmLocation ilocation = new frmLocation();

            //Subscribe this form for callback
            ilocation.AddItemCallback = new frmLocation.AddItemDelegate(AddItemCallbackFn);
            ilocation.ShowDialog();
            lblSource.Text = TempString;
        }

        private void btnDestinationUrl_Click(object sender, EventArgs e)
        {
            frmLocation ilocation = new frmLocation();
            //Subscribe this form for callback
            ilocation.AddItemCallback = new frmLocation.AddItemDelegate(this.AddItemCallbackFn);
            ilocation.ShowDialog();
            lblDestination.Text = TempString;
        }
    }
}
