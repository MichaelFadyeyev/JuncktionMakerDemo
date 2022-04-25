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
        ToolStripMenuItem ttt = new ToolStripMenuItem();
        public Form1()
        {
            InitializeComponent();
            localization.SetLocalization("");
            menuStrip.Items[0].Text = localization.MenuOptions;
            menuStrip.Items[1].Text = localization.MenuAbout;
            var qqq = menuStrip.Items[1] as ToolStripMenuItem;

            ttt.DropDownItems.AddRange(new ToolStripItem[] { new ToolStripMenuItem("inner")});


            //menuStrip.Items.Add(new ToolStripMenuItem(localization.MenuOptions));

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
            //if (junctionRadio.Checked || symbolicDirRadio.Checked)
            //{
            //}
            targetField.Text = OperationManager.GetTargetItem();
        }


        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                OperationManager.CreateLink();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 
        private void clearButton_Click(object sender, EventArgs e)
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