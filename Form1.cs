using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;

namespace ApacheWindowsDeploy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // btnDeploy_Click(null, EventArgs.Empty);
        }

        private void btnBrowseApache_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbApachePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnBrowsePhp_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbPhpPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnDeploy_Click(object sender, EventArgs e)
        {
            if (tbApachePath.Text =="" || !Directory.Exists(tbApachePath.Text))
            {
                MessageBox.Show("Apache path does not exists");
                return;
            }
            if (tbPhpPath.Text == "" || !Directory.Exists(tbPhpPath.Text))
            {
                MessageBox.Show("PHP path does not exists");
                return;
            }

            if (tbInstanceName.Text == "" ) // todo check valid instance name
            {
                MessageBox.Show("Instance name empty or invalid");
                return;
            }

            log("Depling.. pass folder check"); 
            
            if (ServiceController.GetServices().FirstOrDefault(s => s.ServiceName == tbInstanceName.Text) != null) {
                DialogResult result = MessageBox.Show("Instance  already installed, Do you want to remove it", "Warning",  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    log("stopping instance");
                    cmd("sc stop " + tbInstanceName.Text);
                    log("removing instance "+ tbInstanceName.Text);
                    cmd(tbApachePath.Text + "\\bin\\httpd -k uninstall -n \"" + tbInstanceName.Text + "\"");
                }               
                return;
            }


            string EOL = "\r\n";

            log("Creating directories");
            Directory.CreateDirectory(tbApachePath.Text + @"\vhosts");
            DirectoryInfo apacheExtraPath = Directory.CreateDirectory(tbApachePath.Text + @"\extra");
            Directory.CreateDirectory(tbApachePath.Text + @"\ssl");

            log("Copy extra dlls for curl");
            if (!File.Exists(apacheExtraPath.FullName + @"\libeay32.dll"))
                File.Copy(@"extra\libeay32.dll", apacheExtraPath.FullName + @"\libeay32.dll");
            if (!File.Exists(apacheExtraPath.FullName + @"\libssh2.dll"))
                File.Copy(@"extra\libssh2.dll", apacheExtraPath.FullName + @"\libssh2.dll");
            if (!File.Exists(apacheExtraPath.FullName + @"\ssleay32.dll"))
                File.Copy(@"extra\ssleay32.dll", apacheExtraPath.FullName + @"\ssleay32.dll");        

            @File.Copy(@"extra\cacert.pem", apacheExtraPath.FullName + @"\cacert.pem", true);            

            string conf_path = tbApachePath.Text + @"\conf\httpd-apms.conf";

            log("add directive path to httpd conf file");
            string cont = "Define PHPBIN \""+ tbPhpPath.Text.Replace("\\","/")  + "/php7apache2_4.dll" + "\"" + EOL;
            cont += "Define PHPINI \"" + apacheExtraPath.FullName.Replace("\\", "/") + "/\"" + EOL;
            cont += "Define EXTRA \"" + apacheExtraPath.FullName.Replace("\\", "/")  + "/\"" + EOL;

            File.WriteAllText(conf_path, cont + File.ReadAllText(@"extra\httpd.conf"));

            log("add directive to php.ini file");
            string phpcont = "[PHP]" + EOL;
            phpcont += "error_log=\"" + tbApachePath.Text + "\\logs\\php-error.log\"" + EOL;
            phpcont += "extension_dir=\"" + tbPhpPath.Text + "\\ext\\\"" + EOL;
            
            File.WriteAllText(apacheExtraPath.FullName + @"\php.ini" , phpcont + File.ReadAllText(@"extra\php.ini"));

            log("install service " + tbInstanceName.Text);
            cmd( tbApachePath.Text + "\\bin\\httpd -k install -n \"" + tbInstanceName.Text + "\" -f  conf/httpd-apms.conf");

            //log("start service " + tbInstanceName.Text);
            //cmd("sc start " + tbInstanceName.Text);
        }

        private void cmd(string commande)
        {
            //todo better returnig values log
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C " + commande ;
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            log(output);
            process.WaitForExit();
        }
 
        private void log(string s)
        {
            tbLog.Text += DateTime.Now + " " + s + "\r\n";
        }
        
        
    }
}
