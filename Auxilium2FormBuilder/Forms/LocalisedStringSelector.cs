using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auxilium2FormBuilder.Forms
{
    public partial class LocalisedStringSelector : Form
    {

        public bool HasSelectedString { get; private set; } = false;
        public string SelectedString { get; private set; }

        public LocalisedStringSelector()
        {
            InitializeComponent();
        }

        void PopulateListView(ListView listView, string basePath, JsonObject jsonObject)
        {
            foreach (var kvp in jsonObject)
            {
                string currentPath = string.IsNullOrEmpty(basePath) ? kvp.Key : $"{basePath}/{kvp.Key}";

                if (kvp.Value is JsonObject nestedObject)
                {
                    PopulateListView(listView, currentPath, nestedObject);
                }
                else if (kvp.Value is JsonObject || kvp.Value is JsonArray)
                {
                    continue;
                }
                else if (kvp.Value is JsonValue value)
                {
                    var existingItem = listView.Items.Cast<ListViewItem>().FirstOrDefault(item => item.Tag?.ToString() == basePath);

                    if (existingItem == null)
                    {
                        ListViewItem listViewItem = new()
                        {
                            Text = basePath,
                            Tag = basePath,
                        };

                        listViewItem.SubItems.Add(kvp.Key == "en" ? value.ToString() : string.Empty);
                        listViewItem.SubItems.Add(kvp.Key == "cy" ? value.ToString() : string.Empty);
                        listViewItem.SubItems.Add(kvp.Key == "zh" ? value.ToString() : string.Empty);

                        listView.Items.Add(listViewItem);
                    }
                    else
                    {
                        existingItem.Text = basePath;
                        if (kvp.Key == "en")
                            existingItem.SubItems[1].Text = value.ToString();
                        else if (kvp.Key == "cy")
                            existingItem.SubItems[2].Text = value.ToString();
                        else if (kvp.Key == "zh")
                            existingItem.SubItems[3].Text = value.ToString();
                    }
                }
            }
        }

        private void LocalisedStringSelector_Load(object sender, EventArgs e)
        {
            foreach (var group in Program.LocalisedStrings.AsObject())
            {
                TabPage tabPage = new()
                {
                    Name = "tabPage_" + group.Key,
                    Text = group.Key,
                };

                ListView listView = new()
                {
                    View = View.Details,
                    Anchor = AnchorStyles.None,
                    Dock = DockStyle.Fill,
                    FullRowSelect = true,
                    MultiSelect = false,
                };
                listView.Columns.Add("Key", 400);
                listView.Columns.Add("English", 400);
                listView.Columns.Add("Welsh", 400);
                listView.Columns.Add("Chinese", 400);

                listView.DoubleClick += anyListView_DoubleClick;

                tabPage.Controls.Add(listView);

                if (group.Value is JsonObject groupObject)
                {
                    PopulateListView(listView, group.Key, groupObject);
                }

                this.tabControl1.TabPages.Add(tabPage);
            }
        }

        private void anyListView_DoubleClick(object sender, EventArgs e)
        {
            if (sender is ListView listView && listView.SelectedItems.Count == 1)
            {
                var temp = listView.SelectedItems[0].Tag;
                this.HasSelectedString = true;
                this.SelectedString = temp.ToString();
                this.Close();
            }
        }

    }
}
