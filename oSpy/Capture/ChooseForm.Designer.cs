//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

namespace oSpy.Capture
{
    partial class ChooseForm
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
            this.label1 = new System.Windows.Forms.Label ();
            this.startBtn = new System.Windows.Forms.Button ();
            this.cancelBtn = new System.Windows.Forms.Button ();
            this.tabControl1 = new System.Windows.Forms.TabControl ();
            this.processesTabPage = new System.Windows.Forms.TabPage ();
            this.processView = new System.Windows.Forms.ListView ();
            this.usbDevicesTabPage = new System.Windows.Forms.TabPage ();
            this.restartDevicesCheckBox = new System.Windows.Forms.CheckBox ();
            this.usbDevView = new System.Windows.Forms.ListView ();
            this.tabControl1.SuspendLayout ();
            this.processesTabPage.SuspendLayout ();
            this.usbDevicesTabPage.SuspendLayout ();
            this.SuspendLayout ();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point (16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (121, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose what to monitor:";
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.Location = new System.Drawing.Point (403, 291);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size (75, 23);
            this.startBtn.TabIndex = 7;
            this.startBtn.Text = "&Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler (this.startBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point (484, 291);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size (75, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "&Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add (this.processesTabPage);
            this.tabControl1.Controls.Add (this.usbDevicesTabPage);
            this.tabControl1.Location = new System.Drawing.Point (15, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size (544, 260);
            this.tabControl1.TabIndex = 9;
            // 
            // processesTabPage
            // 
            this.processesTabPage.Controls.Add (this.processView);
            this.processesTabPage.Location = new System.Drawing.Point (4, 22);
            this.processesTabPage.Name = "processesTabPage";
            this.processesTabPage.Padding = new System.Windows.Forms.Padding (3);
            this.processesTabPage.Size = new System.Drawing.Size (536, 234);
            this.processesTabPage.TabIndex = 0;
            this.processesTabPage.Text = "Processes";
            this.processesTabPage.UseVisualStyleBackColor = true;
            // 
            // processView
            // 
            this.processView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.processView.CheckBoxes = true;
            this.processView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processView.Location = new System.Drawing.Point (3, 3);
            this.processView.Name = "processView";
            this.processView.Size = new System.Drawing.Size (530, 228);
            this.processView.TabIndex = 2;
            this.processView.UseCompatibleStateImageBehavior = false;
            this.processView.View = System.Windows.Forms.View.List;
            this.processView.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler (this.anyView_ItemCheck);
            // 
            // usbDevicesTabPage
            // 
            this.usbDevicesTabPage.Controls.Add (this.restartDevicesCheckBox);
            this.usbDevicesTabPage.Controls.Add (this.usbDevView);
            this.usbDevicesTabPage.Location = new System.Drawing.Point (4, 22);
            this.usbDevicesTabPage.Name = "usbDevicesTabPage";
            this.usbDevicesTabPage.Padding = new System.Windows.Forms.Padding (3);
            this.usbDevicesTabPage.Size = new System.Drawing.Size (536, 234);
            this.usbDevicesTabPage.TabIndex = 1;
            this.usbDevicesTabPage.Text = "USB devices";
            this.usbDevicesTabPage.UseVisualStyleBackColor = true;
            // 
            // restartDevicesCheckBox
            // 
            this.restartDevicesCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.restartDevicesCheckBox.AutoSize = true;
            this.restartDevicesCheckBox.Location = new System.Drawing.Point (3, 214);
            this.restartDevicesCheckBox.Name = "restartDevicesCheckBox";
            this.restartDevicesCheckBox.Size = new System.Drawing.Size (322, 17);
            this.restartDevicesCheckBox.TabIndex = 2;
            this.restartDevicesCheckBox.Text = "Restart devices to avoid manual replugging (EXPERIMENTAL)";
            this.restartDevicesCheckBox.UseVisualStyleBackColor = true;
            // 
            // usbDevView
            // 
            this.usbDevView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.usbDevView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.usbDevView.CheckBoxes = true;
            this.usbDevView.Location = new System.Drawing.Point (3, 3);
            this.usbDevView.Name = "usbDevView";
            this.usbDevView.Size = new System.Drawing.Size (530, 205);
            this.usbDevView.TabIndex = 1;
            this.usbDevView.UseCompatibleStateImageBehavior = false;
            this.usbDevView.View = System.Windows.Forms.View.List;
            this.usbDevView.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler (this.anyView_ItemCheck);
            // 
            // ChooseForm
            // 
            this.AcceptButton = this.startBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size (571, 326);
            this.Controls.Add (this.tabControl1);
            this.Controls.Add (this.cancelBtn);
            this.Controls.Add (this.startBtn);
            this.Controls.Add (this.label1);
            this.MaximizeBox = false;
            this.Name = "ChooseForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Capture";
            this.Shown += new System.EventHandler (this.InjectForm_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler (this.ChooseForm_FormClosing);
            this.tabControl1.ResumeLayout (false);
            this.processesTabPage.ResumeLayout (false);
            this.usbDevicesTabPage.ResumeLayout (false);
            this.usbDevicesTabPage.PerformLayout ();
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage processesTabPage;
        private System.Windows.Forms.TabPage usbDevicesTabPage;
        private System.Windows.Forms.ListView usbDevView;
        private System.Windows.Forms.ListView processView;
        private System.Windows.Forms.CheckBox restartDevicesCheckBox;

    }
}
