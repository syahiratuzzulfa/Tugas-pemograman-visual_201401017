/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 28/02/2022
 * Time: 23:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace listboxabsen
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void Label5Click(object sender, EventArgs e)
		{
			comboBox1.Items.Add("senin");
			comboBox1.Items.Add("selasa");
			comboBox1.Items.Add("rabu");
			comboBox1.Items.Add("kamis");
			comboBox1.Items.Add("jumat");
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			string hari=(string)comboBox1.SelectedItem;
			waktu(hari);
		}
		
			void waktu (string hari)
			{
				listBox1.Items.Clear();
				listBox1.SelectionMode=SelectionMode.MultiSimple;
				if (hari=="senin")
				{
					listBox1.Items.Add("hadir");
					listBox1.Items.Add("izin");
					listBox1.Items.Add("telat");
					listBox1.Items.Add("sakit");
				}
				else if (hari=="selasa")
				{
					listBox1.Items.Add("hadir");
					listBox1.Items.Add("izin");
					listBox1.Items.Add("telat");
					listBox1.Items.Add("sakit");
				}
				else if (hari=="rabu")
				{
					listBox1.Items.Add("hadir");
					listBox1.Items.Add("izin");
					listBox1.Items.Add("telat");
					listBox1.Items.Add("sakit");
				}
				else if (hari=="kamis")
				{
					listBox1.Items.Add("hadir");
					listBox1.Items.Add("izin");
					listBox1.Items.Add("telat");
					listBox1.Items.Add("sakit");
				}
				else if (hari=="jumat")
				{
					listBox1.Items.Add("hadir");
					listBox1.Items.Add("izin");
					listBox1.Items.Add("telat");
					listBox1.Items.Add("sakit");
				}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show("absen sukses"," selamat belajar", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}

