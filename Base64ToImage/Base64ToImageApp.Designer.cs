using System.ComponentModel;

namespace Base64ToImage;

partial class Base64ToImageApp
{
    private IContainer components = null;
    private Button btnConvert;
    private Button btnClear;
    private RichTextBox txtBase64Input;
    private PictureBox pictureBox;
    private Label lblInstructions;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.btnConvert = new Button();
        this.btnClear = new Button();
        this.txtBase64Input = new RichTextBox();
        this.pictureBox = new PictureBox();
        this.lblInstructions = new Label();
        ((ISupportInitialize)(this.pictureBox)).BeginInit();
        this.SuspendLayout();

        // Convert Button
        this.btnConvert.Location = new Point(20, 150);
        this.btnConvert.Name = "btnConvert";
        this.btnConvert.Size = new Size(100, 30);
        this.btnConvert.TabIndex = 0;
        this.btnConvert.Text = "Convert";
        this.btnConvert.UseVisualStyleBackColor = true;
        this.btnConvert.Click += new EventHandler(this.btnConvert_Click);

        // Clear Button
        this.btnClear.Location = new Point(130, 150);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new Size(100, 30);
        this.btnClear.TabIndex = 1;
        this.btnClear.Text = "Clear";
        this.btnClear.UseVisualStyleBackColor = true;
        this.btnClear.Click += new EventHandler(this.btnClear_Click);

        // RichTextBox for Base64 Input
        this.txtBase64Input.Location = new Point(20, 40);
        this.txtBase64Input.Multiline = true;
        this.txtBase64Input.Name = "txtBase64Input";
        this.txtBase64Input.Size = new Size(400, 100);
        this.txtBase64Input.TabIndex = 3;

        // PictureBox for displaying image
        this.pictureBox.Location = new Point(20, 200);
        this.pictureBox.Name = "pictureBox";
        this.pictureBox.Size = new Size(320, 240);
        this.pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        this.pictureBox.TabIndex = 4;
        this.pictureBox.TabStop = false;

        // Label Instructions
        this.lblInstructions.AutoSize = true;
        this.lblInstructions.Location = new Point(20, 20);
        this.lblInstructions.Name = "lblInstructions";
        this.lblInstructions.Size = new Size(256, 15);
        this.lblInstructions.TabIndex = 5;
        this.lblInstructions.Text = "Enter Base64 string of an image and click Convert.";

        // Base64ToImageApp
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(450, 460);
        this.Controls.Add(this.lblInstructions);
        this.Controls.Add(this.pictureBox);
        this.Controls.Add(this.txtBase64Input);
        this.Controls.Add(this.btnClear);
        this.Controls.Add(this.btnConvert);
        this.Name = "Base64ToImageApp";
        this.Text = "Base64 to Image Converter";
        ((ISupportInitialize)(this.pictureBox)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}