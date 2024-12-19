using System.ComponentModel;

namespace Base64ToImage;

partial class ImageViewer
{
    private PictureBox _pictureBox;
    private Button _btnSave;
    private IContainer components = null;
    
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
        _pictureBox = new PictureBox();
        _btnSave = new Button();
        ((ISupportInitialize)_pictureBox).BeginInit();
        SuspendLayout();

        // PictureBox
        _pictureBox.Dock = DockStyle.Fill;
        _pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        _pictureBox.TabIndex = 0;
        _pictureBox.TabStop = false;

        // Save Button
        _btnSave.Dock = DockStyle.Bottom;
        _btnSave.Text = "Save Image";
        _btnSave.Click += BtnSave_Click;

        // ImageViewerForm
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 600);
        Controls.Add(_pictureBox);
        Controls.Add(_btnSave);
        Name = "ImageViewerForm";
        Text = "Image Viewer";
        ((ISupportInitialize)_pictureBox).EndInit();
        ResumeLayout(false);
    }
}