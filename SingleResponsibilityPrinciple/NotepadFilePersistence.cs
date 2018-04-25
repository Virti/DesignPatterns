using System.IO;

namespace SingleResponsibilityPrinciple
{
    public class NotepadFilePersistence
    {
        public void Save(Notepad notepad, string fileName)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(fileName));
            File.WriteAllText(fileName, notepad.ToString());
        }

        public Notepad Load(string fileName)
        {
            var notepadContents = File.ReadAllLines(fileName);

            var notepad = new Notepad();
            foreach (var notepadEntry in notepadContents)
                notepad.Add(notepadEntry);

            return notepad;
        }
    }
}