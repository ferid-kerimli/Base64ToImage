namespace Base64ToImage;

public partial class Base64ToImageApp : Form
{
    public Base64ToImageApp()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen; // Center the form on startup
    }

    private void btnConvert_Click(object sender, EventArgs e)
    {
        try
        {
            // Clean up the Base64 string and handle any data URI prefix
            var base64String = txtBase64Input.Text.Replace("\n", "").Replace("\r", "");
            if (base64String.StartsWith("data:image"))
            {
                var commaIndex = base64String.IndexOf(',');
                base64String = base64String.Substring(commaIndex + 1);
            }

            // Convert the Base64 string to an image
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using var ms = new MemoryStream(imageBytes);
            var image = Image.FromStream(ms);

            // Open the image in the viewer form
            using var viewerForm = new ImageViewer(image);
            viewerForm.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Invalid Base64 string. Please enter a valid image data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtBase64Input.Clear();
    }
}