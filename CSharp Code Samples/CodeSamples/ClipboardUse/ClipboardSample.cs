using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CodeSamples.ClipboardUse
{
    internal class ClipboardSample : SampleExecute
    {
        /// <summary>
        /// CFSTR_PREFERREDDROPEFFECT
        /// </summary>
        public const string FileDropEffect = "Preferred DropEffect";

        /// <summary>
        /// DROPEFFECT_MOVE
        /// </summary>
        public const byte DropEffectMove = 0x02;

        /// <summary>
        /// DROPEFFECT_COPY
        /// </summary>
        public const byte DropEffectCopy = 0x05;

        private bool HasFilesInClipboard()
        {
            return Clipboard.GetDataObject().GetDataPresent(DataFormats.FileDrop);
        }

        private void CopyFilesToClipboard(List<string> filesToCopy, bool cutOperation)
        {
            if (filesToCopy.Count != 0)
            {
                string[] files = new string[filesToCopy.Count];
                filesToCopy.CopyTo(files, 0);

                IDataObject data = new DataObject(DataFormats.FileDrop, files);
                //or:
                //IDataObject data = new DataObject();
                //data.SetData("FileDrop", true, files);

                MemoryStream memory = new MemoryStream(4);
                byte[] bytes = new byte[] { (byte)(cutOperation ? DropEffectMove : DropEffectCopy), 0x00, 0x00, 0x00 };
                memory.Write(bytes, 0, bytes.Length);

                data.SetData("Preferred DropEffect", memory);
                Clipboard.SetDataObject(data);
            }
        }

        private List<string> PasteFilesFromClipboard()
        {
            var result = new List<string>();

            if (!HasFilesInClipboard()) return result;

            IDataObject data = Clipboard.GetDataObject();

            string[] files = (string[])data.GetData(DataFormats.FileDrop);
            MemoryStream stream = (MemoryStream)data.GetData(FileDropEffect, true);

            int flag = stream.ReadByte();
            if (flag != DropEffectMove && flag != DropEffectCopy)
                return result;

            bool moveFiles = (flag == DropEffectMove);

            foreach (string file in files)
            {
                result.Add(file);
            }

            return result;
        }

        public override void Execute()
        {
            Title("ClipboardSampleExecute");

            Finish();
        }
    }
}
