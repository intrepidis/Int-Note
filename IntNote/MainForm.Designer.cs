using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace IntNote
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MainForm : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontFaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PageModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DefaultDarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrueDarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeepSlateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JazzyAmoledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.MoreComingSoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ChangelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutNotepadCloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
            this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
            this.FontDialog1 = new System.Windows.Forms.FontDialog();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.FormatToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(826, 28);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveCtrlSToolStripMenuItem,
            this.ToolStripSeparator1,
            this.PrintToolStripMenuItem,
            this.ToolStripSeparator2,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.NewToolStripMenuItem.Text = "New";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveCtrlSToolStripMenuItem
            // 
            this.SaveCtrlSToolStripMenuItem.Name = "SaveCtrlSToolStripMenuItem";
            this.SaveCtrlSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveCtrlSToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.SaveCtrlSToolStripMenuItem.Text = "Save";
            this.SaveCtrlSToolStripMenuItem.Click += new System.EventHandler(this.SaveCtrlSToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.PrintToolStripMenuItem.Text = "Print";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripMenuItem,
            this.ToolStripSeparator3,
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.ToolStripSeparator4,
            this.SelectAllToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.UndoToolStripMenuItem.Text = "Undo";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(202, 6);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.CutToolStripMenuItem.Text = "Cut";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.CopyToolStripMenuItem.Text = "Copy";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.PasteToolStripMenuItem.Text = "Paste";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(202, 6);
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.SelectAllToolStripMenuItem.Text = "Select All";
            this.SelectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // FormatToolStripMenuItem
            // 
            this.FormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontFaceToolStripMenuItem,
            this.FontColorToolStripMenuItem,
            this.PageModeToolStripMenuItem});
            this.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem";
            this.FormatToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.FormatToolStripMenuItem.Text = "Format";
            // 
            // FontFaceToolStripMenuItem
            // 
            this.FontFaceToolStripMenuItem.Name = "FontFaceToolStripMenuItem";
            this.FontFaceToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.FontFaceToolStripMenuItem.Text = "Font Face";
            this.FontFaceToolStripMenuItem.Click += new System.EventHandler(this.FontFaceToolStripMenuItem_Click);
            // 
            // FontColorToolStripMenuItem
            // 
            this.FontColorToolStripMenuItem.Name = "FontColorToolStripMenuItem";
            this.FontColorToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.FontColorToolStripMenuItem.Text = "Font Color";
            this.FontColorToolStripMenuItem.Click += new System.EventHandler(this.FontColorToolStripMenuItem_Click);
            // 
            // PageModeToolStripMenuItem
            // 
            this.PageModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DefaultDarkToolStripMenuItem,
            this.TrueDarkToolStripMenuItem,
            this.DeepSlateToolStripMenuItem,
            this.JazzyAmoledToolStripMenuItem,
            this.ToolStripSeparator6,
            this.MoreComingSoonToolStripMenuItem});
            this.PageModeToolStripMenuItem.Name = "PageModeToolStripMenuItem";
            this.PageModeToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.PageModeToolStripMenuItem.Text = "Page Mode";
            // 
            // DefaultDarkToolStripMenuItem
            // 
            this.DefaultDarkToolStripMenuItem.Name = "DefaultDarkToolStripMenuItem";
            this.DefaultDarkToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.DefaultDarkToolStripMenuItem.Text = "Default Dark";
            this.DefaultDarkToolStripMenuItem.Click += new System.EventHandler(this.DefaultDarkToolStripMenuItem_Click);
            // 
            // TrueDarkToolStripMenuItem
            // 
            this.TrueDarkToolStripMenuItem.Name = "TrueDarkToolStripMenuItem";
            this.TrueDarkToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.TrueDarkToolStripMenuItem.Text = "True Gray";
            this.TrueDarkToolStripMenuItem.Click += new System.EventHandler(this.TrueDarkToolStripMenuItem_Click);
            // 
            // DeepSlateToolStripMenuItem
            // 
            this.DeepSlateToolStripMenuItem.Name = "DeepSlateToolStripMenuItem";
            this.DeepSlateToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.DeepSlateToolStripMenuItem.Text = "Deep Slate";
            this.DeepSlateToolStripMenuItem.Click += new System.EventHandler(this.DeepSlateToolStripMenuItem_Click);
            // 
            // JazzyAmoledToolStripMenuItem
            // 
            this.JazzyAmoledToolStripMenuItem.Name = "JazzyAmoledToolStripMenuItem";
            this.JazzyAmoledToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.JazzyAmoledToolStripMenuItem.Text = "Jazzy Amoled";
            this.JazzyAmoledToolStripMenuItem.Click += new System.EventHandler(this.JazzyAmoledToolStripMenuItem_Click);
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(217, 6);
            // 
            // MoreComingSoonToolStripMenuItem
            // 
            this.MoreComingSoonToolStripMenuItem.Name = "MoreComingSoonToolStripMenuItem";
            this.MoreComingSoonToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.MoreComingSoonToolStripMenuItem.Text = "More coming soon!";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem,
            this.ToolStripSeparator5,
            this.ChangelogToolStripMenuItem,
            this.AboutNotepadCloneToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.AboutToolStripMenuItem.Text = "View Help";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(189, 6);
            // 
            // ChangelogToolStripMenuItem
            // 
            this.ChangelogToolStripMenuItem.Name = "ChangelogToolStripMenuItem";
            this.ChangelogToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.ChangelogToolStripMenuItem.Text = "What\'s New";
            this.ChangelogToolStripMenuItem.Click += new System.EventHandler(this.ChangelogToolStripMenuItem_Click);
            // 
            // AboutNotepadCloneToolStripMenuItem
            // 
            this.AboutNotepadCloneToolStripMenuItem.Name = "AboutNotepadCloneToolStripMenuItem";
            this.AboutNotepadCloneToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.AboutNotepadCloneToolStripMenuItem.Text = "About Int-Note";
            this.AboutNotepadCloneToolStripMenuItem.Click += new System.EventHandler(this.AboutNotepadCloneToolStripMenuItem_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBox1.Location = new System.Drawing.Point(0, 28);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox1.Size = new System.Drawing.Size(826, 399);
            this.TextBox1.TabIndex = 1;
            // 
            // PrintDialog1
            // 
            this.PrintDialog1.UseEXDialog = true;
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // SaveFileDialog1
            // 
            this.SaveFileDialog1.DefaultExt = "txt";
            this.SaveFileDialog1.FileName = "Untitled";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(826, 427);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.MenuStrip1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Int-Note";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal MenuStrip MenuStrip1;
        internal ToolStripMenuItem FileToolStripMenuItem;
        internal ToolStripMenuItem NewToolStripMenuItem;
        internal ToolStripMenuItem OpenToolStripMenuItem;
        internal ToolStripMenuItem SaveCtrlSToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripMenuItem EditToolStripMenuItem;
        internal ToolStripMenuItem FormatToolStripMenuItem;
        internal ToolStripMenuItem HelpToolStripMenuItem;
        internal ToolStripMenuItem PrintToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripMenuItem ExitToolStripMenuItem;
        internal ToolStripMenuItem UndoToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator3;
        internal ToolStripMenuItem CutToolStripMenuItem;
        internal ToolStripMenuItem CopyToolStripMenuItem;
        internal ToolStripMenuItem PasteToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator4;
        internal ToolStripMenuItem SelectAllToolStripMenuItem;
        internal ToolStripMenuItem FontFaceToolStripMenuItem;
        internal ToolStripMenuItem FontColorToolStripMenuItem;
        internal ToolStripMenuItem AboutToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator5;
        internal ToolStripMenuItem AboutNotepadCloneToolStripMenuItem;
        internal TextBox TextBox1;
        internal PrintDialog PrintDialog1;
        internal ColorDialog ColorDialog1;
        internal FontDialog FontDialog1;
        internal OpenFileDialog OpenFileDialog1;
        internal SaveFileDialog SaveFileDialog1;
        internal ToolStripMenuItem PageModeToolStripMenuItem;
        internal ToolStripMenuItem TrueDarkToolStripMenuItem;
        internal ToolStripMenuItem DeepSlateToolStripMenuItem;
        internal ToolStripMenuItem DefaultDarkToolStripMenuItem;
        internal ToolStripMenuItem JazzyAmoledToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator6;
        internal ToolStripMenuItem MoreComingSoonToolStripMenuItem;
        internal ToolStripMenuItem ChangelogToolStripMenuItem;

    }
}