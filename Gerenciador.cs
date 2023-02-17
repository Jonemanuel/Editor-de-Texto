using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace EditorTXT
{
    public static class Gerenciador
    {
        //Valores padrão
        public static string DefaultFolderPath => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";

        public static string DefaultFileName => "Arquivo";

        public static string DefaultFileExt => ".txt";

        //Valores atribuido ao uso
        public static string Folderpath { get; set; } = DefaultFolderPath;
        public static string FileName { get; set; } = DefaultFileName;
        public static string FileExt { get; set; } = DefaultFileExt;

        public static string FilePath => Folderpath + FileName + FileExt;
    }
}
