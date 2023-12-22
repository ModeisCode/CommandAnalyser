using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandAnalyser
{
    public partial class CommandPanelComponent : Panel
    {

        Panel top_panel = new Panel();
        Label id_label = new Label();
        String id = "empty_id";
        String tag = "empty_tag";

        public CommandPanelComponent()
        {
            InitializeComponent();
            commandPictureBox.Size = new Size(70, 50);
            commandPictureBox.Dock = DockStyle.Left;
            commandPictureBox.Parent = this;
            
            CommandTextBox.Size = new Size(100, 50);
            CommandTextBox.Dock = DockStyle.Top;
            CommandTextBox.Parent = this;

            top_panel.Size = new Size(100,20);
            top_panel.BackColor = Color.Gray;
            top_panel.Dock = DockStyle.Top;
            top_panel.Parent = this;

            CommandDescriptionRTB.Size = new Size(380, 60); 
            CommandDescriptionRTB.Dock = DockStyle.None;
            CommandDescriptionRTB.Location = new Point(100,40);
            CommandDescriptionRTB.Parent = this;

            id_label.Size = new Size(50,20);
            id_label.ForeColor = Color.Lime;
            id_label.Parent = top_panel;
            id_label.Text = id;


        }

        public CommandPanelComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void set_parent(Control parent) 
        {
            this.Parent = parent;

        }

        public void set_location(Point point) 
        {
            this.Location = point;
        }

        public void set_backcolor(Color color) 
        {
            this.BackColor = color;
        }

        public void set_size(Size size) 
        {
            this.Size = size;
        }

        public void set_dock(DockStyle dockStyle) 
        {
            this.Dock = dockStyle;
        }

        public void set_image(PictureBox pictureBox) 
        {
            commandPictureBox.Image = pictureBox.Image;
            commandPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }


    }
}
