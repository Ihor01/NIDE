﻿using System;
using System.IO;
using NIDE.UI;

namespace NIDE.ProjectTypes.MCPEModding.ZCore
{
    public partial class FModInfo : DialogForm
    {
        private ModInfo info;
        private string filename;

        public FModInfo(string filename, string name = "", string author = "")
        {
            InitializeComponent();
            this.filename = filename;
            try
            {
                string json = File.ReadAllText(filename);
                info = json.ToObject<ModInfo>();
                if (info == null)
                    throw new Exception();
            }
            catch
            {
                info = new ModInfo(name, author, "1.0", "");
            }
            TbName.Text = info.name;
            TbAuthor.Text = info.author;
            TbVersion.Text = info.version;
            TbDescription.Text = info.description;
            cbIndent.Checked = RegistryWorker.indentModInfo;
        }

        protected override void OnOk()
        {
            info.name = TbName.Text;
            info.author = TbAuthor.Text;
            RegistryWorker.User = TbAuthor.Text;
            info.version = TbVersion.Text;
            info.description = TbDescription.Text;
            RegistryWorker.indentModInfo = cbIndent.Checked;
            string json = info.ToJson(cbIndent.Checked);
            File.WriteAllText(filename, json);
            Close();
        }

        private class ModInfo
        {
            public string name;
            public string author;
            public string version;
            public string description;

            public ModInfo() { }

            public ModInfo(string name, string author, string version, string description)
            {
                this.name = name;
                if (author == "")
                    this.author = RegistryWorker.User;
                else this.author = author;
                this.version = version;
                this.description = description;
            }            
        }
    }
}
