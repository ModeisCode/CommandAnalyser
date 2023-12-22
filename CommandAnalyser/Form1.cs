using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandAnalyser
{
    public partial class Form1 : Form
    {

        List<CommandPanelComponent> commands = new List<CommandPanelComponent>();

        public Form1()
        {
            InitializeComponent();
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            CommandPanelComponent commandPanelComponent = new CommandPanelComponent();
            commandPanelComponent.set_backcolor(Color.DarkGray);
            commandPanelComponent.set_dock(DockStyle.Top);
            commandPanelComponent.set_parent(CommandPanel);
            commandPanelComponent.set_size(new Size(100,100));
            commandPanelComponent.set_image(cmdImage);
        }

        private void TestSaveToJSON_Click(object sender, EventArgs e)
        {

        }
    }
}
