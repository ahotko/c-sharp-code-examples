using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CodeSamples.ClipboardUse
{
    internal class ClipboardSample : SampleExecute
    {
        //https://docs.microsoft.com/en-us/windows/win32/com/dropeffect-constants
        // Constant         Value       Description
        //===================================================================
        //DROPEFFECT_NONE   0           Drop target cannot accept the data.
        //DROPEFFECT_COPY   1           Drop results in a copy. The original data is untouched by the drag source.
        //DROPEFFECT_MOVE   2           Drag source should remove the data.
        //DROPEFFECT_LINK   4           Drag source should create a link to the original data.
        //DROPEFFECT_SCROLL 0x80000000  Scrolling is about to start or is currently occurring in the target. This value is used in addition to the other values.


        /// <summary>
        /// CFSTR_PREFERREDDROPEFFECT
        /// </summary>
        public const string FileDropEffect = "Preferred DropEffect";

        /// <summary>
        /// DROPEFFECT_MOVE
        /// </summary>
        public const uint DropEffectMove = (uint)0x00000002;

        /// <summary>
        /// DROPEFFECT_COPY
        /// </summary>
        public const uint DropEffectCopy = (uint)0x00000005;

        /// <summary>
        /// DROPEFFECT_SCROLL
        /// </summary>
        public const uint DropEffectScroll = (uint)0x80000000;

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

                using (MemoryStream memory = new MemoryStream(sizeof(uint)))
                {
                    var writer = new BinaryWriter(memory);
                    writer.Write((cutOperation ? DropEffectMove : DropEffectCopy));

                    data.SetData(FileDropEffect, memory);
                    Clipboard.SetDataObject(data);
                }
            }
        }

        private List<string> PasteFilesFromClipboard()
        {
            var result = new List<string>();

            if (!HasFilesInClipboard()) return result;

            IDataObject data = Clipboard.GetDataObject();

            string[] files = (string[])data.GetData(DataFormats.FileDrop);
            MemoryStream stream = (MemoryStream)data.GetData(FileDropEffect, true);

            var reader = new BinaryReader(stream);

            uint flags = reader.ReadUInt32();

            if ((flags & DropEffectMove) != DropEffectMove && (flags & DropEffectCopy) != DropEffectCopy)
                return result;
            
            bool moveFiles = ((flags & DropEffectMove) == DropEffectMove);

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
