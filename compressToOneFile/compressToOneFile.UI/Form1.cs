using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using compressToOneFile.Entities;
using Utilities;

namespace compressToOneFile.UI
{
    public partial class Form1 : Form
    {
        private Logger logger = new Logger("Console");
        public Form1()
        {
            InitializeComponent();
        }

        private void compressBtn_Click(object sender, EventArgs e)
        {
            string sourcePath = sourceTxt.Text.Trim();
            if (string.IsNullOrEmpty(sourcePath))
            {
                logger.LogError(new LogItem { Type = "Error", LogTime = DateTime.Now, Message = "Please fill source path." });
                MessageBox.Show("Please fill source path.");
                return;
            }
            if (!Directory.Exists(sourcePath))
            {
                logger.LogError(new LogItem { Type = "Error", LogTime = DateTime.Now, Message = "The source path does not exist." });
                MessageBox.Show("The source path does not exist.");
                return;
            }

            string destinationPath = desinationTxt.Text.Trim();
            if (string.IsNullOrEmpty(destinationPath))
            {
                logger.LogError(new LogItem { Type = "Error", LogTime = DateTime.Now, Message = "Please fill destination path." });
                MessageBox.Show("Please fill destination path.");
                return;
            }

            if (Directory.Exists(destinationPath))
            {
                logger.LogError(new LogItem { Type = "Error", LogTime = DateTime.Now, Message = "The desination path alredy exist, please fill another path." });
                MessageBox.Show("The desination path alredy exist, please fill another path.");
                return;
            }

            string destoinationExtnsion = Path.GetExtension(destinationPath).ToLowerInvariant();
            if (destoinationExtnsion != ".zip" && destoinationExtnsion != ".rar")
            {
                logger.LogError(new LogItem { Type = "Error", LogTime = DateTime.Now, Message = "The destination path must have a .zip or .rar extension." });
                MessageBox.Show("The destination path must have a .zip or .rar extension.");
                return;
            }

            try
            {
                logger.LogEvent(new LogItem { Type = "Event", LogTime = DateTime.Now, Message = "initialize details of CompressionOptions in form1" });
                CompressionOptions options = new CompressionOptions();
                options.CompressionLevel = CompressionLevel.Optimal;
                options.FileExtension = destoinationExtnsion;

                logger.LogEvent(new LogItem { Type = "Event", LogTime = DateTime.Now, Message = "Start the compressing." });
                CompressionService compressionService  = new CompressionService();
                CompressionResult result = compressionService.CompressDirectory(sourcePath, destinationPath, options);

                if (result.IsSuccess)
                {
                    logger.LogEvent(new LogItem { Type = "Event", LogTime = DateTime.Now, Message = "Compression successful. Compressed file saved to " + result.CompressedFilePath });
                    MessageBox.Show("Compression successful. Compressed file saved to " + result.CompressedFilePath);
                }
                else
                {
                    logger.LogError(new LogItem { Type = "Error", LogTime = DateTime.Now, Message = "Compression failed." });
                    MessageBox.Show("Compression failed.");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(new LogItem { Type = "Error", LogTime = DateTime.Now, Message = "Compression failed." + ex.Message });
                MessageBox.Show("Compression failed: " + ex.Message);
            }
        }
    }
}
