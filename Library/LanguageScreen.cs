using Business;
using Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LanguageScreen : Form
    {
        LanguageManager _langaugeManager = new();

        public LanguageScreen()
        {
            InitializeComponent();
        }

        public void DGV()
        {
            var allLanguage = _langaugeManager.GetAllLanguages().Select(language => new
            {
                Id = language.Id,
                Language = language.LanguageName,
            }).ToList();

            DgvLanguage.DataSource = allLanguage;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var languageName = TxtLanguage.Text;
            var emptyLanguageName = string.IsNullOrEmpty(languageName);
            if (emptyLanguageName)
            {
                MessageBox.Show("fill in the blanks");
            }
            else
            {
                try
                {
                    Language _language = new()
                    {
                        LanguageName = languageName,
                    };
                    _langaugeManager.AddLanguage(_language);
                    DialogResult result = MessageBox.Show("Author is added", "Add", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        TxtLanguage.Text = string.Empty;
                        DGV();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Something is wrong ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }

        private void LanguageScreen_Load(object sender, EventArgs e)
        {
            DGV();
        }
    }
}
