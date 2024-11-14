using System.ComponentModel;

namespace Base64ToImage;

partial class Base64ToImageApp
{
    private IContainer components = null;
    private Button btnConvert;
    private Button btnClear;
    private RichTextBox txtBase64Input;
    private Label lblInstructions;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnConvert = new System.Windows.Forms.Button();
        btnClear = new System.Windows.Forms.Button();
        txtBase64Input = new System.Windows.Forms.RichTextBox();
        lblInstructions = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // btnConvert
        // 
        btnConvert.Location = new System.Drawing.Point(23, 200);
        btnConvert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        btnConvert.Name = "btnConvert";
        btnConvert.Size = new System.Drawing.Size(114, 40);
        btnConvert.TabIndex = 0;
        btnConvert.Text = "Convert";
        btnConvert.UseVisualStyleBackColor = true;
        btnConvert.Click += btnConvert_Click;
        // 
        // btnClear
        // 
        btnClear.Location = new System.Drawing.Point(149, 200);
        btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        btnClear.Name = "btnClear";
        btnClear.Size = new System.Drawing.Size(114, 40);
        btnClear.TabIndex = 1;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += btnClear_Click;
        // 
        // txtBase64Input
        // 
        txtBase64Input.Location = new System.Drawing.Point(23, 53);
        txtBase64Input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        txtBase64Input.Name = "txtBase64Input";
        txtBase64Input.Size = new System.Drawing.Size(457, 132);
        txtBase64Input.TabIndex = 3;
        txtBase64Input.Text = "";
        // 
        // lblInstructions
        // 
        lblInstructions.AutoSize = true;
        lblInstructions.Location = new System.Drawing.Point(23, 27);
        lblInstructions.Name = "lblInstructions";
        lblInstructions.Size = new System.Drawing.Size(339, 20);
        lblInstructions.TabIndex = 5;
        lblInstructions.Text = "Enter Base64 string of an image and click Convert.";
        // 
        // Base64ToImageApp
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(514, 613);
        Controls.Add(lblInstructions);
        Controls.Add(txtBase64Input);
        Controls.Add(btnClear);
        Controls.Add(btnConvert);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Text = "Base64 to Image Converter";
        ResumeLayout(false);
        PerformLayout();
    }
}