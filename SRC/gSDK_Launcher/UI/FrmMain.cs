﻿/*
*************************************************************************************
Tis file is distributed under MIT license:
*************************************************************************************
The MIT License (MIT)

Copyright © 2013-2014 EpicMorg

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the ''Software''), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED ''AS IS'', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.", @"The MIT License (MIT)
*************************************************************************************
*/
using System.IO;
using System.Linq;
using gSDK_vgui;
using System.Windows.Forms;
using System;
namespace gSDK_Launcher {
    public partial class FrmMain : FrmTemplate {
        
        public FrmMain() {
            InitializeComponent();
        }
        private void btn_about_Click(object sender, EventArgs e) {
            new frm_about().ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e) {
            new frm_scanning().ShowDialog();
        }
        private void btn_settings_Click(object sender, EventArgs e) {
           new frm_settings().ShowDialog();
        }
        private void btn_exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private void frm_main_Load( object sender, EventArgs e ) {
            var configpath = Path.Combine( "configs", "list.xml" );
            try {
                Globals.Config = Config.Load( configpath );
            }
            catch (Exception ex) {
                if ( MessageBox.Show(
                    "Cant't load config file. Create new?",
                    "ЕГГОГ!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error ) != DialogResult.OK )
                    return;
                try {
                    File.WriteAllText( configpath, Properties.Resources.dftcfg );
                }
                catch (Exception ex2) {
                    MessageBox.Show(
                        "ЕГГОГ",
                        "Unable to update config. Contact to ya odmin.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error );
                    Application.Exit();
                    return;
                }
            }
            this.listv_programs.Items.Clear();
            //this.listv_programs.Items.AddRange(
            //    Globals.Config.Apps.Select( 
            //    )
            //);
            this.listv_programs.BeginUpdate();
            foreach (var category in Globals.Config.Apps) {
                var grp = new ListViewGroup( category.Name );
                this.listv_programs.Groups.Add( grp );
                foreach (var app in category.Apps) {
                    var Item = new ListViewItem( app.Name, grp );
                    this.listv_programs.Items.Add( Item );
                }
            }
            this.listv_programs.EndUpdate();
        }
    }
}