using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.BONEWORKS
{
    internal class BoneworksSettings : UserControl
    {
        private CheckBox checkBox1;

        public BoneworksSettings()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // BoneworksSettings
            // 
            this.Controls.Add(this.checkBox1);
            this.Name = "BoneworksSettings";
            this.Load += new System.EventHandler(this.BoneworksSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BoneworksSettings_Load(object sender, System.EventArgs e)
        {

        }

        public XmlNode UpdateSettings(XmlDocument document)
        {
            XmlElement xmlSettings = document.CreateElement("Settings");

            AddXmlItem<bool>(document, xmlSettings, "Test", checkBox1.Checked);

            return xmlSettings;
        }

        public void AddXmlItem<T>(XmlDocument document, XmlElement xmlSettings, string name, T value)
        {
            XmlElement xmlItem = document.CreateElement(name);
            xmlItem.InnerText = value.ToString();
            xmlSettings.AppendChild(xmlItem);
        }
    }
}