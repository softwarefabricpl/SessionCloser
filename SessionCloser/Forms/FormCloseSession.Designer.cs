namespace SessionCloser.Forms
{
    partial class FormCloseSession
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
            this.kryptonHeaderDown = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.buttonSave = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonClose = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.LblConfirmation = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // kryptonHeaderDown
            // 
            this.kryptonHeaderDown.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSave,
            this.buttonClose});
            this.kryptonHeaderDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonHeaderDown.Location = new System.Drawing.Point(0, 56);
            this.kryptonHeaderDown.Name = "kryptonHeaderDown";
            this.kryptonHeaderDown.Size = new System.Drawing.Size(421, 28);
            this.kryptonHeaderDown.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonHeaderDown.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonHeaderDown.TabIndex = 911;
            this.kryptonHeaderDown.Values.Description = "";
            this.kryptonHeaderDown.Values.Heading = "";
            this.kryptonHeaderDown.Values.Image = null;
            // 
            // buttonSave
            // 
            this.buttonSave.Image = global::SessionCloser.Properties.Resources.gtk_ok;
            this.buttonSave.Text = "Save";
            this.buttonSave.UniqueName = "D8E287A26DC14ED9D8E287A26DC14ED9";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Image = global::SessionCloser.Properties.Resources.remove;
            this.buttonClose.Text = "Close";
            this.buttonClose.UniqueName = "B1A67B4AA6804A22B1A67B4AA6804A22";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // LblConfirmation
            // 
            this.LblConfirmation.Location = new System.Drawing.Point(12, 12);
            this.LblConfirmation.Name = "LblConfirmation";
            this.LblConfirmation.Size = new System.Drawing.Size(88, 20);
            this.LblConfirmation.TabIndex = 912;
            this.LblConfirmation.Values.Text = "kryptonLabel1";
            // 
            // FormCloseSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 84);
            this.Controls.Add(this.LblConfirmation);
            this.Controls.Add(this.kryptonHeaderDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCloseSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeaderDown;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSave;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonClose;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LblConfirmation;
    }
}