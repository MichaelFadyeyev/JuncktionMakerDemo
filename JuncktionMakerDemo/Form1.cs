using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using JuncktionMakerDemo.Operations;
using JuncktionMakerDemo.Localizations;
using System.Diagnostics;
using System.Windows.Forms;



namespace JuncktionMakerDemo
{
    public partial class Form1 : Form
    {
        LocalizationManager localization = new LocalizationManager();
        ToolStripMenuItem optionsMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem langugeMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem aboutMenuItem = new ToolStripMenuItem();
        public Form1()
        {
            InitializeComponent();
            optionsMenuItem.DropDownItems.AddRange(new ToolStripMenuItem[] { langugeMenuItem });
            menuStrip.Items.AddRange(new ToolStripMenuItem[] { optionsMenuItem, aboutMenuItem });

            LoadLocalizedUI();


        }

        private void LoadLocalizedUI()
        {
            localization.SetLocalization("");
            optionsMenuItem.Text = localization.MenuOptions;
            langugeMenuItem.Text = localization.MenuLanguage;
            aboutMenuItem.Text = localization.MenuAbout;

            linkType.Text = localization.LinkType;
            modeSelect.DataSource = localization.Modes;
            sourceButtom.Text = localization.Source;
            targetButton.Text = localization.Target;
            createButton.Text = localization.Create;
            clearButton.Text = localization.Clear;
        }

        private void sourceButtom_Click(object sender, EventArgs e)
        {
                OperationManager.TargetPath = "";
                targetField.Clear();                
                sourceField.Text = OperationManager.GetSourceItem();
        }

        private void targetButton_Click(object sender, EventArgs e)
        {
            targetField.Text = OperationManager.GetTargetItem();
        }


        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                OperationManager.CreateLink();
                ClearFields();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        void ClearFields()
        {
            OperationManager.SourcePath = "";
            sourceField.Clear();
            OperationManager.TargetPath = "";
            targetField.Clear();
        }

        private void modeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            OperationManager.ModeIndex = modeSelect.SelectedIndex;
        }
    }
}