//<summary>
//  Title   : Republish notification message
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2009, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

namespace CAS.OPC.UA.Viewer.Controls
{
    partial class RepublishNotificationMessageDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( RepublishNotificationMessageDlg ) );
          this.SequenceNumberLB = new System.Windows.Forms.Label();
          this.ButtonsPN = new System.Windows.Forms.Panel();
          this.OkBTN = new System.Windows.Forms.Button();
          this.CancelBTN = new System.Windows.Forms.Button();
          this.panel1 = new System.Windows.Forms.Panel();
          this.SequenceNumberNC = new System.Windows.Forms.NumericUpDown();
          this.ButtonsPN.SuspendLayout();
          this.panel1.SuspendLayout();
          ( (System.ComponentModel.ISupportInitialize)( this.SequenceNumberNC ) ).BeginInit();
          this.SuspendLayout();
          // 
          // SequenceNumberLB
          // 
          this.SequenceNumberLB.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                      | System.Windows.Forms.AnchorStyles.Left )
                      | System.Windows.Forms.AnchorStyles.Right ) ) );
          this.SequenceNumberLB.AutoSize = true;
          this.SequenceNumberLB.Location = new System.Drawing.Point( 4, 9 );
          this.SequenceNumberLB.Name = "SequenceNumberLB";
          this.SequenceNumberLB.Size = new System.Drawing.Size( 96, 13 );
          this.SequenceNumberLB.TabIndex = 0;
          this.SequenceNumberLB.Text = "Sequence Number";
          this.SequenceNumberLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
          // 
          // ButtonsPN
          // 
          this.ButtonsPN.Controls.Add( this.OkBTN );
          this.ButtonsPN.Controls.Add( this.CancelBTN );
          this.ButtonsPN.Dock = System.Windows.Forms.DockStyle.Bottom;
          this.ButtonsPN.Location = new System.Drawing.Point( 0, 33 );
          this.ButtonsPN.Name = "ButtonsPN";
          this.ButtonsPN.Size = new System.Drawing.Size( 300, 31 );
          this.ButtonsPN.TabIndex = 0;
          // 
          // OkBTN
          // 
          this.OkBTN.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
          this.OkBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
          this.OkBTN.Location = new System.Drawing.Point( 4, 4 );
          this.OkBTN.Name = "OkBTN";
          this.OkBTN.Size = new System.Drawing.Size( 75, 23 );
          this.OkBTN.TabIndex = 1;
          this.OkBTN.Text = "OK";
          this.OkBTN.UseVisualStyleBackColor = true;
          this.OkBTN.Click += new System.EventHandler( this.OkBTN_Click );
          // 
          // CancelBTN
          // 
          this.CancelBTN.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
          this.CancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
          this.CancelBTN.Location = new System.Drawing.Point( 221, 4 );
          this.CancelBTN.Name = "CancelBTN";
          this.CancelBTN.Size = new System.Drawing.Size( 75, 23 );
          this.CancelBTN.TabIndex = 0;
          this.CancelBTN.Text = "Cancel";
          this.CancelBTN.UseVisualStyleBackColor = true;
          // 
          // panel1
          // 
          this.panel1.Controls.Add( this.SequenceNumberNC );
          this.panel1.Controls.Add( this.SequenceNumberLB );
          this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
          this.panel1.Location = new System.Drawing.Point( 0, 0 );
          this.panel1.Name = "panel1";
          this.panel1.Size = new System.Drawing.Size( 300, 33 );
          this.panel1.TabIndex = 1;
          // 
          // SequenceNumberNC
          // 
          this.SequenceNumberNC.Location = new System.Drawing.Point( 106, 7 );
          this.SequenceNumberNC.Maximum = new decimal( new int[] {
            -1,
            0,
            0,
            0} );
          this.SequenceNumberNC.Name = "SequenceNumberNC";
          this.SequenceNumberNC.Size = new System.Drawing.Size( 84, 20 );
          this.SequenceNumberNC.TabIndex = 1;
          this.SequenceNumberNC.Value = new decimal( new int[] {
            -1,
            0,
            0,
            0} );
          // 
          // RepublishNotificationMessageDlg
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size( 300, 64 );
          this.Controls.Add( this.panel1 );
          this.Controls.Add( this.ButtonsPN );
          this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
          this.MinimumSize = new System.Drawing.Size( 287, 98 );
          this.Name = "RepublishNotificationMessageDlg";
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
          this.Text = "Republish Notification Message";
          this.ButtonsPN.ResumeLayout( false );
          this.panel1.ResumeLayout( false );
          this.panel1.PerformLayout();
          ( (System.ComponentModel.ISupportInitialize)( this.SequenceNumberNC ) ).EndInit();
          this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Label SequenceNumberLB;
        private System.Windows.Forms.Panel ButtonsPN;
        private System.Windows.Forms.Button OkBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown SequenceNumberNC;
    }
}
