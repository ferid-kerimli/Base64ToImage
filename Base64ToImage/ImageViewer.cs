using System.Drawing.Imaging;

namespace Base64ToImage;

public partial class ImageViewer : Form
{
    private readonly Image _originalImage; // Store the original image

    public ImageViewer(Image image)
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
        _originalImage = image; // Keep the original image
        _pictureBox.Image = _originalImage; // Display the original image
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        using SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
        saveFileDialog.Title = "Save Image";
        saveFileDialog.FileName = "";

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                ImageFormat format; // Default format
                switch (Path.GetExtension(saveFileDialog.FileName)?.ToLower())
                {
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    default:
                        format = ImageFormat.Jpeg;
                        break;
                }

                // Calculate the new size maintaining the aspect ratio
                int newWidth, newHeight;
                double aspectRatio = (double)_originalImage.Width / _originalImage.Height;

                if (_originalImage.Width > _originalImage.Height)
                {
                    newWidth = 800; // Example fixed width
                    newHeight = (int)(newWidth / aspectRatio);
                }
                else
                {
                    newHeight = 600; // Example fixed height
                    newWidth = (int)(newHeight * aspectRatio);
                }

                // Create a new bitmap and draw the original image on it
                using Bitmap resizedImage = new Bitmap(newWidth, newHeight);
                using (Graphics graphics = Graphics.FromImage(resizedImage))
                {
                    graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    graphics.DrawImage(_originalImage, 0, 0, newWidth, newHeight);
                }

                // Save the resized image
                resizedImage.Save(saveFileDialog.FileName, format);
                MessageBox.Show("Image saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving image: {ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}