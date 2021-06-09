using System;
using System.Windows.Forms;

namespace GD_BD_BIBLIO
{
    public partial class HTML_view : Form
    {
        #region Constructeur
        public HTML_view()
        {
            InitializeComponent();
        }
        #endregion

        #region Méthodes
        private void HTML_view_Load(object sender, EventArgs e)
        {
            //génère la destination du ficher html
            string htmlDirectory = "F:\\COURS\\POO\\GD_BD_BIBLIO\\bin\\debug\\livre_stock.html";
            //ouvrir le navigateur
            webBrowser1.Url = new Uri(String.Format(htmlDirectory));
        } 
        #endregion
    }
}