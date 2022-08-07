using System.Diagnostics;
namespace wishlist_app.forms;
public partial class viewer : Form
{
    public viewer()
    {
        InitializeComponent();
    }

    private void btn_add_from_url_Click(object sender, EventArgs e)
    {
        //var url = txt_url.Text;
        //if (url == "") return;
        //if (!Uri.IsWellFormedUriString(url, UriKind.Absolute)) return;
        //table.SuspendLayout();
        //var new_row_index = table.RowCount + 1;
        //table.RowStyles.Add(new RowStyle() { SizeType = SizeType.Absolute, Height = 40 });
        //table.Controls.Add(new PictureBox() { SizeMode = PictureBoxSizeMode.Zoom, Image = Image.FromFile(@"C:\Users\Rafay\OneDrive\Pictures\201827289_4264755903582527_3580659760432314509_n (2).jpg") });
        //table.Controls.Add(new Label() { Text = "Product Name" });
        //table.Controls.Add(new Label() { Text = "Product Price" });
        //var link = new LinkLabel() { Text = txt_url.Text };
        //link.Click += new EventHandler(open_url);
        //table.Controls.Add(link);
        //table.ResumeLayout();
        table.Rows.Add(Image.FromFile(@"C:\Users\Rafay\OneDrive\Pictures\201827289_4264755903582527_3580659760432314509_n (2).jpg"), "I'm Selling my own body");
    }
    private void open_url(object sender, EventArgs e) => Process.Start(new ProcessStartInfo(((LinkLabel)sender).Text) { UseShellExecute = true, Verb = "open" });
}