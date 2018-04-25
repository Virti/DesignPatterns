using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    public class Notepad
    {
        private readonly List<string> _notes = new List<string>();
        private int _count = 0;

        public void Add(string note)
        {
            _notes.Add($"{++_count}. {DateTime.UtcNow}: {note}");
        }

        public void Remove(int index)
        {
            _notes.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _notes);
        }

        /*
        Putting theese here will violate Single Responsibility Pattern making Notepad class responsible
        not only for managing single notes but also saving/loading them to the filesystem for example.
         
        public Notepad Load(string fileName) { }
        public void Save(string fileName) { }

        Instead, we need to implement another class responsible just for notepad persistence - see 
        NotepadFilePersistence.cs.
        */
    }
}