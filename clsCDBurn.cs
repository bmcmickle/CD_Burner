using DiscUtils.Iso9660;
using System;
using System.IO;

namespace CD_Burner
{
    internal class clsCDBurn
    {
        public string TargetIso { get; set; }
        public clsCDBurn() { }


        //var res = CreateIsoImage("D:\\", "C:\\Temp\\MyIsoImage.iso", "MyVolumeName");
        // MessageBox.Show(res);
        public string CreateIsoImage(string sourceDrive, string targetIso, string volumeName)
        {
            try
            {
                var srcFiles = Directory.GetFiles(sourceDrive, "*", SearchOption.AllDirectories);
                var iso = new CDBuilder
                {
                    UseJoliet = true,
                    VolumeIdentifier = volumeName
                };

                foreach (var file in srcFiles)
                {
                    var fi = new FileInfo(file);
                    if (fi.Directory.Name == sourceDrive)
                    {
                        iso.AddFile($"{fi.Name}", fi.FullName);
                        continue;
                    }
                    var srcDir = fi.Directory.FullName.Replace(sourceDrive, "").TrimEnd('\\');
                    iso.AddDirectory(srcDir);
                    iso.AddFile($"{srcDir}\\{fi.Name}", fi.FullName);
                }

                iso.Build(targetIso);
                TargetIso = targetIso;
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }

}
