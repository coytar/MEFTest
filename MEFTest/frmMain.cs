using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MEFTest
{
    public partial class FrmMain : Form
    {
        CompositionContainer container = null;
        Dictionary<string, string> driverPaths = new Dictionary<string, string>();
        Dictionary<string, int> driverInstances = new Dictionary<string, int>();

        public FrmMain()
        {
            InitializeComponent();

            LoadContainer();
            LoadDriversList();
        }

        public void LoadContainer()
        {
            container = new CompositionContainer(new AggregateCatalog());
        }

        public void LoadDriversList()
        {
            string[] subFolders = System.IO.Directory.GetDirectories(Application.StartupPath + "\\drivers\\");
            foreach (var subFolder in subFolders)
            {
                var dirCat = new DirectoryCatalog(subFolder, "*.dll");
                var exportDef = dirCat.ElementAt(0).ExportDefinitions.ToList();
                var name = exportDef[0].Metadata["name"].ToString();
                driverPaths.Add(name, dirCat.LoadedFiles[0]);
                lstDriversList.Items.Add(name);
            }
        }

        public void LoadDriver(string driverName)
        {
            string path = driverPaths[driverName];

            // Create a new instance
            Assembly szDLLPath = Assembly.LoadFile(path);
            Type typeDLL = szDLLPath.GetType("MEFTest." + driverName);
            IDriver objDLL = (IDriver) Activator.CreateInstance(typeDLL);

            // Generate a unique name for each instance
            string name = driverName;
            if (driverInstances.ContainsKey(name))
            {
                int i = driverInstances[name];
                i += 1;
                driverInstances[name] = i;
                name += i.ToString();
            }
            else
            {
                driverInstances.Add(name, 0);
                name += "0";
            }

            // Add the instance to the container
            container.ComposeExportedValue<IDriver>(name, objDLL);
            lstLoadedDrivers.Items.Add(name);
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            string driverName = lstDriversList.SelectedItem.ToString();
            LoadDriver(driverName);
        }

        private void BtnGetAlarms_Click(object sender, EventArgs e)
        {
            // Get the instance from the container
            string driverInstanceName = lstLoadedDrivers.SelectedItem.ToString();
            IDriver driver = container.GetExportedValue<IDriver>(driverInstanceName);

            lstAlarms.Items.Clear();
            foreach (Alarm alm in driver.GetActiveAlarms())
            {
                lstAlarms.Items.Add(alm.Source + "," + alm.Tag + "," + alm.Description);
            }
        }
    }
}
